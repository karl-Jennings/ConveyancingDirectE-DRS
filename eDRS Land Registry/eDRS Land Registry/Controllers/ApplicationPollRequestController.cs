using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessGatewayServices;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayModels;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using Newtonsoft.Json;

namespace eDRS_Land_Registry.Controllers
{
    public class ApplicationPollRequest
    {
        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }
    public class ApplicationPollController : ApiController
    {

        [HttpPost]
        public RequestLog ApplicationPollRequest([FromBody] TempClass tempClass)
        {
            try
            {
                ApplicationPollRequest Request = JsonConvert.DeserializeObject<ApplicationPollRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                var response = _services.PollRequest(Request.Username, Request.Password, Request.MessageId);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;
                requestLog.Type = "Poll";
                requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                requestLog.Description = response.GatewayResponse.GatewayResponse.Results.MessageDetails;

                byte[] bytes = response.GatewayResponse.GatewayResponse.Results.DespatchDocument.Value;
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                requestLog.FileName = response.GatewayResponse.GatewayResponse.Results.DespatchDocument.filename;
                requestLog.FileExtension = response.GatewayResponse.GatewayResponse.Results.DespatchDocument.format;

                requestLog.File = base64String;

                return requestLog;

            }
            catch (Exception ex)
            {
                return new RequestLog { IsSuccess = false };
            }

        }
    }
}
