using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class Representation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RepresentationId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public long RepresentativeId { get; set; }
        public string Name { get; set; }

        public string Reference { get; set; }
        public string AddressType { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }


        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }

        public string DxNumber { get; set; }
        public string DxExchange { get; set; }


        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

    }

}
