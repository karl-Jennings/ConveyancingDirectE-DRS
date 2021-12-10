using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class AdditionalAddress_PostalAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }

        [ForeignKey("AddressForService_AdditionalAddress")]
        public long AddressForService_AdditionalAddressId { get; set; }

        [JsonIgnore]
        public AddressForService_AdditionalAddress AddressForService_AdditionalAddress { get; set; }
    }
}
