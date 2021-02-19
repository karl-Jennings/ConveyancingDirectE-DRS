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
using eDrsManagers.ApiConverters;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.TransferOfPart;

namespace eDrsAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //XMLConverter();
        }

        public IConfiguration Configuration { get; }
        private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; // ignores models' case sensitive when converting to json object
                options.UseMemberCasing();
            });
            services.AddMvc();

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
                options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"))
            );

            services.AddAutoMapper(typeof(Startup)); // adding auto mapper profile

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

            IdentityModelEventSource.ShowPII = true;


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext context)
        {
            context.Database.Migrate();


            app.UseDeveloperExceptionPage();


            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


        public void XMLConverter()
        {

            string xml = System.IO.File.ReadAllText(@"E:\Accura-tech\LR eDRS Dev\Backend\LrApiManager\PoolResponse.txt");

            xml = xml.Replace("ns3:", "");
            xml = xml.Replace("ns4:", "");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // XML convert to Jason
            string json = JsonConvert.SerializeXmlNode(doc);
            var jo = JObject.Parse(json);

            //get GatewayResponse from Jason object
            var _GatewayResponse = jo["getResponseResponse"]["GatewayResponse"].ToString();

            _GatewayResponse = _GatewayResponse.Replace("@filename", "filename");
            _GatewayResponse = _GatewayResponse.Replace("@format", "format");
            _GatewayResponse = _GatewayResponse.Replace("#text", "byteArray");

            // Deserialize Jason to object
            TransferOfPartsPollResponse gatewayResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TransferOfPartsPollResponse>(_GatewayResponse);


        }
    }
}