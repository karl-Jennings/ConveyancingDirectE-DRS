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

        public ResponseCorrespondenceRequest Post([FromBody] TempClass tempClass)
        {
            ResponseCorrespondenceRequest response = new ResponseCorrespondenceRequest();
            try
            {
                CorrospondanceRequest request = JsonConvert.DeserializeObject<CorrospondanceRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                response = _services.CorrespondenceRequest(request.Username, request.Password, request.MessageId);

                return response;

            }
            catch (Exception ex)
            {
                response.Successful = false;
                return response;
            }

        }
    }
}
