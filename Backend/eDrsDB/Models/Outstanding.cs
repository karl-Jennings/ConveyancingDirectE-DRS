using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class Outstanding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OutstandingId { get; set; }
         
        public string LandRegistryId { get; set; }
        public string ServiceType { get; set; }
        public bool NewResponse { get; set; }
        public int TypeCode { get; set; }
        public string Type { get; set; }

        public long DocumentReferenceId { get; set; }

        [JsonIgnore]
        public DocumentReference DocumentReference { get; set; }
    }
}
