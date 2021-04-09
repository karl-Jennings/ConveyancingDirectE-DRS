using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text; 
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class Party
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PartyId { get; set; }

        [Required]
        public bool IsApplicant { get; set; }

        [Required]
        public string CompanyOrForeName { get; set; }
        public string Surname { get; set; }

        [Required]
        public string Roles { get; set; }

        [Required]
        public List<string> ViewModelRoles { get; set; }

        [Required]
        public string PartyType { get; set; }
        public string AddressForService { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        public DocumentReference DocumentReference { get; set; }

        public ICollection<Address> Addresses { get; set; }

    }
}
