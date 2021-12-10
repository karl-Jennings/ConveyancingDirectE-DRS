using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class AddressForService
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public AddressForService_PostalAddress PostalAddress { get; set; }
        public ICollection<AddressForService_AdditionalAddress> AdditionalAddresses { get; set; }
        public string AddressForServiceOption { get; set; }

        [ForeignKey("Party")]
        public long PartyId { get; set; }

        [JsonIgnore]
        public virtual Party Party { get; set; }

    }
}
