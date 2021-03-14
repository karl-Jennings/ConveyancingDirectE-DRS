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

    public class RequestApplicationController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();


        public class TempClass
        {
            public string value { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }


        }

        public RequestLog Post([FromBody] TempClass nice)
        {
            try
            {
                DocumentReference docRef = JsonConvert.DeserializeObject<DocumentReference>(nice.value);

                var apiModel = _restrictionConverter.ArrangeLrApi(docRef);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                var response = _services.eDRSApplicationRequest(nice.Username, nice.Password, apiModel);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;

                requestLog.Type = "Application";
                requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                requestLog.ResponseJson = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse);
                if (response.GatewayResponse.GatewayResponse.Acknowledgement != null)
                {
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Acknowledgement.MessageDescription;
                    requestLog.CreatedDate = Convert.ToDateTime(response.GatewayResponse.GatewayResponse.Acknowledgement.Items[0].ToString());
                    requestLog.ResponseType = "Acknowledgement";

                }
                else if (response.GatewayResponse.GatewayResponse.Rejection != null)
                {
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Code;
                    requestLog.RejectionReason = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Reason;

                    requestLog.ValidationErrors = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.ValidationErrors);

                    requestLog.ResponseType = "Rejection";

                }
                else if (response.GatewayResponse.GatewayResponse.Results != null)
                {
                    requestLog.ResponseType = "Results";
                }


                return requestLog;

            }
            catch (Exception ex)
            {
                var requestLog = new RequestLog();
                requestLog.IsSuccess = false;
                return requestLog;
            }

        }
    }
}
