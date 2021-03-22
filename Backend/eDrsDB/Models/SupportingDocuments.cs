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
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }

        public string AdditionalProviderFilter { get; set; }
        public long MessageId { get; set; }
        public string ExternalReference { get; set; }
        public string ApplicationMessageId { get; set; }
        public string ApplicationService { get; set; }

        public string ApplicationType { get; set; }
        public string DocumentType { get; set; }

        public string Notes { get; set; }

        [MaxLength]
        public string Base64 { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        public DocumentReference DocumentReference { get; set; }

    }
}
