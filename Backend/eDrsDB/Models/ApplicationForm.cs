using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class ApplicationForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ApplicationFormId { get; set; }

        [Required]
        public string Variety { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public int FeeInPence { get; set; }
        
        public string Type { get; set; }

        //[Required]
        public string ExternalReference { get; set; }

        [Required]
        public string CertifiedCopy { get; set; }
        public DateTime? ChargeDate { get; set; }

       // [Required]
        public string IsMdRef { get; set; }
        public string SortCode { get; set; }
        public string MdRef { get; set; }
        public bool IsChecked { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }

        // [Required]      
        public Document Document { get; set; }

    }

    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public long DocumentId { get; set; }

        [Required]
        public long AttachmentId { get; set; }

        [MaxLength]
        [Required]
        public string Base64 { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string FileExtension { get; set; }

        public long ApplicationFormId { get; set; }

        public string ApplicationMessageId { get; set; }

        [JsonIgnore]
        internal ApplicationForm ApplicationForm { get; set; }

        public bool? ApplyToRespondToRequisition { get; set; }
    }
}