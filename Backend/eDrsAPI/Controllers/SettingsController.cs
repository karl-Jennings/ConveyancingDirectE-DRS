using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.Interfaces;

namespace eDrsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogsManager _logsManager;

        public SettingsController(AppDbContext context, ILogsManager logsManager)
        {
            _context = context;
            _logsManager = logsManager;
        }

        [HttpPost]
        public IActionResult ChangeCredentials(LrCredential model)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }
    }
}
