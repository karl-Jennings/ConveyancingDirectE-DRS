using BusinessGatewayRepositories.EDRSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDRS_Land_Registry.Models
{
    public class RequestApplicationViewModel
    {
       public string Username { get; set; }
       public string Password { get; set; }
       public RequestApplicationToChangeRegisterV1_0Type Request { get; set; }
    }
}