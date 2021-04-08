using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using eDrsDB.Data;
using eDrsManagers.Interfaces;
using eDrsManagers.Managers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.Xml;
using eDrsAPI.Controllers;
using eDrsAPI.Swagger;
using eDrsDB.Models;
using eDrsManagers.ApiConverters;
using eDrsManagers.FluentValidation;
using eDrsManagers.FluentValidation.Validators;
using eDrsManagers.Http;
using eDrsManagers.SignalRHub;
using eDrsManagers.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hangfire;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.TransferOfPart;
using Microsoft.OpenApi.Models;

namespace eDrsAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }
        private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize; // ignores models' case sensitive when converting to json object
                options.UseMemberCasing();
            });


            services.AddHangfire(config =>
            {
                config.UseSqlServerStorage(Configuration.GetConnectionString("SqlServerConnection"));
            });

            services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddSignalR().AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            });

            var allowedCors = Configuration.GetSection("AllowedClients").Get<List<string>>(); // getting the whitelisted domains from appsettings
            services.AddCors(options => // add cors restriction
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins(allowedCors.ToArray())
                            .AllowAnyHeader()
                            .AllowAnyMethod().SetIsOriginAllowed(origin => true)
                            .AllowCredentials()
                            .WithExposedHeaders("Content-Disposition");
                    });
            });

            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"),
                    b => b.MigrationsAssembly("eDrsAPI"))
            );

            services.AddAutoMapper(typeof(Startup)); // adding auto mapper profile

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "HM Land Registry - Electronic Document Registration Service API",
                    Version = "v1.1",
                    Description = "API to understand request and response schema.",
                });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) // adding Json Web Token
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ClockSkew = TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecretKey"]))
                    };
                    options.RequireHttpsMetadata = false;
                    options.Events = new JwtBearerEvents
                    {
                        OnChallenge = context => // sending custom message on token failure
                        {
                            var payload = new JObject { ["type"] = "notValid" };

                            // Skip the default logic.
                            context.HandleResponse();
                            context.Response.StatusCode = 401;
                            context.Response.WriteAsync(payload.ToString()).Wait();
                            return Task.CompletedTask;
                        }
                    };

                });
            services.AddAuthorization();

            services.AddScoped<ILogsManager, LogsManager>();
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IRegistration, Registration>();
            services.AddScoped<IRestrictionConverter, RestrictionConverter>();
            services.AddScoped<IHttpEdrsCall, HttpEdrsCall>();
            services.AddScoped<IAttachmentManager, AttachmentManager>();

            IdentityModelEventSource.ShowPII = true;

            services.AddTransient<IValidator<DocumentReferenceViewModel>, DocumentReferenceValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext context, IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider)
        {
            context.Database.Migrate();

            app.UseHangfireServer();

            app.UseHangfireDashboard();

            app.UseDeveloperExceptionPage();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SettingsHub>("/api/settings");
                endpoints.MapHub<AttachmentHub>("/api/attachment");
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HM Land Registry");
                
            });

            //recurringJobManager.AddOrUpdate(
            //    "poll_request",
            //    () => serviceProvider.GetService<IRegistration>().AutomatePollRequest(),
            //    Cron.Weekly(DayOfWeek.Thursday, 0)
            //);

        }


    }
}
