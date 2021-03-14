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

        public EarlyCompletionResponse Post([FromBody] EarlyCompletionRequest request)
        {
            EarlyCompletionResponse response = new EarlyCompletionResponse();
            try
            {
                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                response = _services.EarlyCompletionRequest(request.Username, request.Password, request.MessageId);
               
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
