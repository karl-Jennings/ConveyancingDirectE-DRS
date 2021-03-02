using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eDrsDB.Data;
using eDrsManagers.Interfaces;
using Hangfire;
using Hangfire.Common;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace eDrsManagers.SignalRHub
{
    public class SettingsHub : Hub
    {
        private readonly AppDbContext _context;
        private readonly IRegistration _registration;

        public SettingsHub(AppDbContext context, IRegistration registration)
        {
            _context = context;
            _registration = registration;
        }

        public void CreatePollRequest(int minute)
        {
            string cronExpression = $"*/{minute} * * * *";
            if (minute > 59)
            {
                cronExpression = "* */1 * * *";
            }

            var manager = new RecurringJobManager(); 
            manager.AddOrUpdate("poll_request",
                Job.FromExpression(() => _registration.AutomatePollRequest()), cronExpression
            );

            Clients.All.SendAsync("GetPollRequestMinute", GetPollRequestMinute());
        }

        public int GetPollRequestMinute()
        {
            var minute = 0;
            using var command = _context.Database.GetDbConnection().CreateCommand();
            command.CommandText = "SELECT * From HangFire.Hash where [Key] = 'recurring-job:poll_request' and Field = 'Cron'";
            _context.Database.OpenConnection();
            using var result = command.ExecuteReader();
            if (result.Read())
            {
                var cronStr = result["Value"].ToString();
                if (cronStr.Substring(4, 2).Trim() != "1")
                {
                    var minuteStr = cronStr.Substring(2, 2);
                    minute = Convert.ToInt32(minuteStr.Trim());
                }
                else
                {
                    minute = 60;
                }
            }

            return minute;
        }
    }
}
