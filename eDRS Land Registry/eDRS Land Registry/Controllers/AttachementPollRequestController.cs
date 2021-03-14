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
    public class AttachementPollRequest
    {
        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }
    public partial class AttachementPollController : ApiController
    {

        [HttpPost]        
        public ResponseAttachmentPollRequest AttachmentRequest([FromBody] AttachementPollRequest Request)
        {
            try
            {
                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();             

                var _reponse = _services.AttachmentPollRequest( Request.Username,Request.Password, Request.MessageId);

                return _reponse;

            }
            catch (Exception ex)
            {
                return new ResponseAttachmentPollRequest { Successful = false };
            }

        }
    }
}
