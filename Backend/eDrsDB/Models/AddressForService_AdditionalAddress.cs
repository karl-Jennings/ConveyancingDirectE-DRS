using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class AddressForService_AdditionalAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public AddressForService_DXAddress DXAddress { get; set; }
        public AdditionalAddress_EmailAddress EmailAddress { get; set; }
        public AdditionalAddress_PostalAddress PostalAddress { get; set; }

        [ForeignKey("AddressForService")]
        public long addressForServiceId { get; set; }

        [JsonIgnore]
        public AddressForService AddressForService { get; set; }

    }
}
