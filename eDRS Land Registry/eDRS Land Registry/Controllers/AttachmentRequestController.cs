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
    public class AttachmentController : ApiController
    {

        [HttpPost]
        [Route("AttachmentRequest")]
        public ResponseAttachmentRequest AttachmentRequest(AttachmentViewModel Request)
        {
            try
            {
                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();             

                var _reponse = _services.AttachmentRequest( Request.Username,Request.Password, Request.Request);

                return _reponse;

            }
            catch (Exception ex)
            {
                return new ResponseAttachmentRequest { Successful = false };
            }

        }
    }
}
