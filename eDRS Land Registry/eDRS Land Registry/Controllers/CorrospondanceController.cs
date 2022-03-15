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
    public class CorrospondanceRequest
    {
        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }
    public class corrospondanceController : ApiController
    {

        public RequestLog Post([FromBody] TempClass tempClass)
        {
            ResponseCorrespondenceRequest response = new ResponseCorrespondenceRequest();
            try
            {
                CorrospondanceRequest request = JsonConvert.DeserializeObject<CorrospondanceRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                response = _services.CorrespondenceRequest(request.Username, request.Password, request.MessageId);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;
                requestLog.Type = "correspondence";

                if (response.GatewayResponse !=null && response.GatewayResponse.GatewayResponse!=null) {

                    requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                    requestLog.AppMessageId = response.GatewayResponse.GatewayResponse.ApplicationMessageId;
                    requestLog.ExternalReference = response.GatewayResponse.GatewayResponse.ExternalReference;

                    byte[] bytes = response.GatewayResponse.GatewayResponse.Correspondence.Value;
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                    requestLog.FileName = response.GatewayResponse.GatewayResponse.Correspondence.filename;
                    requestLog.FileExtension = response.GatewayResponse.GatewayResponse.Correspondence.format;

                    requestLog.File = base64String;

                    requestLog.ResponseJson = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse);
                }

              
                return requestLog;

            }
            catch (Exception ex)
            {
                return new RequestLog { IsSuccess = false , 
                    
                    ResponseJson= JsonConvert.SerializeObject(ex.InnerException)
                };
            }

        }
    }
}
