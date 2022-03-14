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
    public class AttachementPollRequest
    {
        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }

    public partial class AttachementPollController : ApiController
    {

        [HttpPost]
        public RequestLog AttachmentRequest([FromBody] TempClass tempClass)
        {
            try
            {
                OutstaningRequest request = JsonConvert.DeserializeObject<OutstaningRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                var _reponse = _services.AttachmentPollRequest(request.Username, request.Password, request.MessageId);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;
                requestLog.Type = "attachment_poll";

                if (_reponse.GatewayResponse!=null) {

                    requestLog.TypeCode = _reponse.GatewayResponse.GatewayResponse.TypeCode.ToString();
                    requestLog.Description = _reponse.GatewayResponse.GatewayResponse.Results.MessageDetails;
                    requestLog.AttachmentId = _reponse.GatewayResponse.GatewayResponse.Results.AttachmentID;
                    requestLog.ExternalReference= _reponse.GatewayResponse.GatewayResponse.Results.ExternalReference;
                }
               

                return requestLog;

            }
            catch (Exception ex)
            {
                return new RequestLog { IsSuccess = false };
            }

        }
    }
}
