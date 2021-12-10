using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class AdditionalAddress_EmailAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Email { get; set; }

        [ForeignKey("AddressForService_AdditionalAddress")]
        public long AddressForService_AdditionalAddressId { get; set; }

        [JsonIgnore]
        public AddressForService_AdditionalAddress AddressForService_AdditionalAddress { get; set; }
    }
}
