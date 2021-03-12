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

namespace eDRS_Land_Registry.Controllers
{

    public class RequestApplicationController : ApiController
    {


        public DocumentReference Post(DocumentReference viewModel)
        {
            try
            {

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                //var _reponse = _services.eDRSApplicationRequest(Request.Username,Request.Password, Request.Request);

                return viewModel;

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
