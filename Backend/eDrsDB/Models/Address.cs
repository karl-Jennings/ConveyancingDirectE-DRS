using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AddressId { get; set; }

        public string Type { get; set; }
        public string SubType { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
        public string DxNumber { get; set; }
        public string DxExchange { get; set; }

        public string EmailAddress { get; set; }

        public long PartyId { get; set; }
        [JsonIgnore]
        public Party Party { get; set; }



    }
}
 