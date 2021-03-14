using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class SupportingDocuments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SupportingDocumentId { get; set; }

        public string CertifiedCopy { get; set; }
        public string DocumentId { get; set; }
        public string DocumentName { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        public DocumentReference DocumentReference { get; set; } 

    }
}
