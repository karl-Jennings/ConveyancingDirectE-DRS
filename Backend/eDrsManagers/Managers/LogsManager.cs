using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Linq;
using Serilog;

namespace eDrsManagers.Managers
{
    public class LogsManager : ILogsManager
    {
        private string _clientMessage = "";
        private readonly List<string> _dbErrors = new List<string>();

        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IConfiguration _configuration;

        public LogsManager(AppDbContext context, IHostingEnvironment appEnvironment, IConfiguration configuration)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _configuration = configuration;
            _dbErrors.Add("SQLServer");
        }

        public JObject LogErrors(Exception ex)
        {
            var temp = ex;
            if (!_dbErrors.Contains(ex.Source))
            {
                try
                {
                    var errorLog = new List<ErrorLogs>();

                    while (ex != null)
                    {
                        errorLog.Add(new ErrorLogs()
                        {
                            ClassName = ex.GetType().FullName,
                            Message = ex.Message,
                            Source = ex.Source,
                            StackTraceString = ex.StackTrace
                        });
                        ex = ex.InnerException;
                    }
                    _context.ErrorLogs.AddRange(errorLog);
                    //context.SaveChanges();
                }
                catch (Exception)
                {
                    WriteToTextFile(temp);
                }

                _clientMessage = temp?.Message;
            }
            else
            {
                _clientMessage = "Please contact Admin if you see this message";
                WriteToTextFile(ex);
            }

            var errorObject = new JObject()
            {
                new JProperty("type", temp?.GetType().FullName),
                new JProperty("message", _clientMessage),
                new JProperty("fullStack", temp?.ToString())
            };
            return errorObject;
        }

        private void WriteToTextFile(Exception ex)
        {
            var rootFolder = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "ErrorLogs")).Root;

            Serilog.Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.File(rootFolder + @"log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Serilog.Log.Fatal(ex, "Application start-up failed");

        }
    }
}
