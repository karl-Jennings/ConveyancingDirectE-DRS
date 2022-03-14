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

        [Required]
        public string CertifiedCopy { get; set; }

        [Required]
        public long DocumentId { get; set; }

        [Required]
        public string DocumentName { get; set; }

        [Required]
        public string AdditionalProviderFilter { get; set; }
        public string MessageId { get; set; }

        [Required]
        public string ExternalReference { get; set; }

        [Required]
        public string ApplicationMessageId { get; set; }
        [Required]
        public string DocumentType { get; set; }

        public string Notes { get; set; }

        [MaxLength]
        public string Base64 { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }


        public bool IsChecked { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }

    }
}
