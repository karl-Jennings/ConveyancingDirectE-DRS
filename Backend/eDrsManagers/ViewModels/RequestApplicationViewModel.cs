using System;
using System.Collections.Generic;
using System.Text;
using BusinessGatewayRepositories.EDRSApplication;

namespace eDrsManagers.ViewModels
{
    public class RequestApplicationViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RequestApplicationToChangeRegisterV1_0Type Request { get; set; }
    }
}
