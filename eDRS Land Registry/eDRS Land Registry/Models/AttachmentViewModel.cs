using BusinessGatewayRepositories.AttachmentServiceRequest;
using BusinessGatewayRepositories.EDRSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDRS_Land_Registry.Models
{
    public class AttachmentViewModel
    {       
        public string Username { get; set; }
        public string Password { get; set; }   
        public AttachmentV2_0Type Request { get; set; }
    }
}