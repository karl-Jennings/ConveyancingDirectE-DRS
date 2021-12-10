using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class AddressForService_DXAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string DXNumber { get; set; }
        [Required]
        public string DXExchange { get; set; }
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }

        [ForeignKey("AddressForService_AdditionalAddress")]
        public long AddressForService_AdditionalAddressId { get; set; }

        [JsonIgnore]
        public AddressForService_AdditionalAddress AddressForService_AdditionalAddress { get; set; }
    }
}
