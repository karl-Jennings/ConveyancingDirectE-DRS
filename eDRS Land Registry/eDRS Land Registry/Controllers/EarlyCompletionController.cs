using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessGatewayServices;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayModels;
using eDRS_Land_Registry.ApiConverters;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using Newtonsoft.Json;

namespace eDRS_Land_Registry.Controllers
{
    public class EarlyCompletionRequest
    {
        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
    public class EarlyCompletionController : ApiController
    {

        public RequestLog Post([FromBody] TempClass tempClass)
        {
            EarlyCompletionResponse response = new EarlyCompletionResponse();
            try
            {
                EarlyCompletionRequest request = JsonConvert.DeserializeObject<EarlyCompletionRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                response = _services.EarlyCompletionRequest(request.Username, request.Password, request.MessageId);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;
                requestLog.Type = "earlyCompletion";
                requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                requestLog.AppMessageId = response.GatewayResponse.GatewayResponse.EarlyCompletion.ApplicationMessageId;

                byte[] bytes = response.GatewayResponse.GatewayResponse.EarlyCompletion.DespatchDocument.Value;
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                requestLog.FileName = response.GatewayResponse.GatewayResponse.EarlyCompletion.DespatchDocument.filename;
                requestLog.FileExtension = response.GatewayResponse.GatewayResponse.EarlyCompletion.DespatchDocument.format;

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
