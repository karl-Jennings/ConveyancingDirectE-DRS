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

namespace eDRS_Land_Registry.Controllers
{
    [Route("api/[controller]")]  
    public class RequestApplicationController : ApiController
    {

        [HttpPost]
        [Route("ApplicationeRequest")]
        public ResponseEDRSAppRequest ApplicationeRequest(RequestApplicationViewModel Request)
        {
            try
            {

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();             

                var _reponse = _services.eDRSApplicationRequest(Request.MessageId, Request.Username,Request.Password, Request.Request);

                return _reponse;

            }
            catch (Exception ex)
            {
                return new ResponseEDRSAppRequest { Successful = false };
            }

        }
    }
}
