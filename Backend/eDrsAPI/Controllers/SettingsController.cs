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
        private readonly ILogsManager _logsManager;
        private readonly ISettingsManager _settingsManager;

        public SettingsController(ILogsManager logsManager, ISettingsManager settingsManager)
        {
            _logsManager = logsManager;
            _settingsManager = settingsManager;
        }

        [HttpGet]
        public IActionResult GetCredentials()
        {
            try
            {
                return Ok(_settingsManager.GetCredentials());
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }

        [HttpPost]
        public IActionResult ChangeCredentials(LrCredential model)
        {
            try
            {
                return Ok(_settingsManager.ChangeCredentials(model));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }
    }
}
