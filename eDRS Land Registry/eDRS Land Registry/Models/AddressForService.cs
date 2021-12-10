using BusinessGatewayRepositories.EDRSApplicationV2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDRS_Land_Registry.Models
{
    public class AddressForService    {
        
        public PostalAddressType PostalAddress { get; set; }
        public List<AdditionalAddress> AdditionalAddresses { get; set; }
        public string AddressForServiceOption { get; set; }
    }
}