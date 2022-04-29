using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDrsDB.Data;
using eDrsManagers.Interfaces;
using Hangfire.Common;
using Microsoft.EntityFrameworkCore;

namespace eDrsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutomationServiceController : ControllerBase
    {
        private readonly IRecurringJobManager _recurringJobManager;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogsManager _logsManager;
        private readonly IRegistration _registration;
        private readonly AppDbContext _context;

        public AutomationServiceController(IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider, ILogsManager logsManager, IRegistration registration, AppDbContext context)
        {
            _recurringJobManager = recurringJobManager;
            _serviceProvider = serviceProvider;
            _logsManager = logsManager;
            _registration = registration;
            _context = context;
        }

        /// <summary>
        /// Setting minute to automate Poll Request
        /// </summary>
        /// <returns>bool</returns>
        [HttpGet]
        public IActionResult AutomatePollRequest(int minute)
        {
            try
            {
                var manager = new RecurringJobManager();
                //manager.RemoveIfExists("poll_request");
                manager.AddOrUpdate("poll_request",
                    Job.FromExpression(() => _registration.AutomatePollRequest()), $"*/{minute} * * * *"
                );


                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = $"SELECT * From HangFire.Hash where [Key] = 'recurring-job:poll_request' and Field = 'Cron'";
                    _context.Database.OpenConnection();
                    using var result = command.ExecuteReader();
                    if (result.Read())
                    {
                        var temp = result["Value"];
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }
    }
}
