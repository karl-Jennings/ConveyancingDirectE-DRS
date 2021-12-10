using BusinessGatewayRepositories.EDRSApplicationV2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDRS_Land_Registry.Models
{
    public class AdditionalAddress
    {
        public AdditionalAddress() { }

        public DXAddressType DXAddress { get; set; }
        public EmailAddressType EmailAddress { get; set; }
        public PostalAddressType PostalAddress { get; set; }
        
    }
}