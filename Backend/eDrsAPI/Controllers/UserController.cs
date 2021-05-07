using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        public IActionResult Login(LoginViewModel viewModel)
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

        /// <summary>
        /// Getting the eDRS user list
        /// </summary>
        /// <returns>Token and boolean</returns> 
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userManager.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Creating/Updating eDRS user
        /// /// </summary>
        /// <returns>Token and boolean</returns> 
        [HttpPost]
        public IActionResult Update(UserViewModel userViewModel)
        {
            try
            {
                return Ok(_userManager.Update(userViewModel));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }


        /// <summary>
        /// Getting Token for login
        /// </summary>
        /// <returns>Token and boolean</returns> 
        [HttpGet]
        public IActionResult CallSoap()
        {
            try
            {
                string xmlMessage = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n" +
                                    "construct your xml request message as required by that method along with parameters";
                string url = "https://bgtest.landregistry.gov.uk";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                byte[] requestInFormOfBytes = System.Text.Encoding.ASCII.GetBytes(xmlMessage);
                request.Method = "POST";
                request.ContentType = "text/xml;charset=utf-8";
                request.ContentLength = requestInFormOfBytes.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(new byte[0x00], 0, requestInFormOfBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader respStream = new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default);
                string receivedResponse = respStream.ReadToEnd();
                Console.WriteLine(receivedResponse);
                respStream.Close();
                response.Close();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

    }
}
