using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDrsManagers.Interfaces;
using eDrsManagers.ViewModels;


namespace eDrsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly ILogsManager _logsManager;

        public UserController(IUserManager userManager, ILogsManager logsManager)
        {
            _userManager = userManager;
            _logsManager = logsManager;
        }

        /// <summary>
        /// Getting Token for login
        /// </summary> 
        /// <param name="viewModel"></param>
        /// <returns>Token and boolean</returns> 
        [HttpPost]
        public IActionResult Login(UserViewModel viewModel)
        {
            try
            {
                return Ok(_userManager.Login(viewModel));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

    }
}
