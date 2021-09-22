using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using eDrsDB.Models;
using Newtonsoft.Json;

namespace eDRS_Land_Registry.ViewModels
{
    public class DocumentReferenceViewModel
    {
        public long DocumentReferenceId { get; set; }

        public string MessageID { get; set; }

        [Required]
        public string Reference { get; set; }

        [Required]
        public int TotalFeeInPence { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public long TelephoneNumber { get; set; }
        public string AdditionalProviderFilter { get; set; }
        public string ExternalReference { get; set; }

        [Required]
        public bool AP1WarningUnderstood { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ApplicationDate { get; set; }

        [Required]
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }

        [Required]
        [StringRange(AllowableValues = new[] { "WHOLE", "PART" }, ErrorMessage = "ApplicationAffectsContent must be either 'WHOLE' or 'PART'.")]
        public string ApplicationAffects { get; set; }
        public bool Status { get; set; }
        public long RegistrationTypeId { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public long UserId { get; set; }

        internal User User { get; set; }

        [Required]
        public ICollection<TitleNumber> Titles { get; set; }

        [Required]
        public ICollection<ApplicationForm> Applications { get; set; }
        public ICollection<SupportingDocuments> SupportingDocuments { get; set; }

        [Required]
        public ICollection<Representation> Representations { get; set; }

        [Required]
        public ICollection<Party> Parties { get; set; }
        internal ICollection<RequestLog> RequestLogs { get; set; }
        internal ICollection<Outstanding> Outstanding { get; set; }
        public bool IsApiSuccess { get; set; }
        public int? OverallStatus { get; set; }

    }

    public class StringRangeAttribute : ValidationAttribute
    {
        public string[] AllowableValues { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (AllowableValues?.Contains(value?.ToString()) == true)
            {
                return ValidationResult.Success;
            }

            var msg = $"Please enter one of the allowable values: {string.Join(", ", AllowableValues ?? new[] { "No allowable values found" })}.";
            return new ValidationResult(msg);
        }
    }

    public class ApplicationForm
    {
       
        public long ApplicationFormId { get; set; }

        [Required]
        public string Variety { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public int FeeInPence { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string ExternalReference { get; set; }

        [Required]
        public string CertifiedCopy { get; set; }
        public DateTime ChargeDate { get; set; }

        [Required]
        public string IsMdRef { get; set; }
        public string SortCode { get; set; }
        public string MdRef { get; set; }
        public bool IsChecked { get; set; }

        public long DocumentReferenceId { get; set; }
        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }

        [Required]
        public Document Document { get; set; }

    }

    public class SupportingDocuments
    {
        
        public long SupportingDocumentId { get; set; }

        [Required]
        public string CertifiedCopy { get; set; }

        [Required]
        public long DocumentId { get; set; }

        [Required]
        public string DocumentName { get; set; }

        [Required]
        public string AdditionalProviderFilter { get; set; }
        public long MessageId { get; set; }

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

    public class Outstanding
    {
        
        public long OutstandingId { get; set; }

        public string LandRegistryId { get; set; }
        public string ServiceType { get; set; }
        public bool NewResponse { get; set; }
        public int TypeCode { get; set; }
        public string Type { get; set; }

        public long DocumentReferenceId { get; set; }

        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }
    }

    public class DocumentReference
    {
       
        public long DocumentReferenceId { get; set; }

        [Required]
        public string Reference { get; set; }
        public int TotalFeeInPence { get; set; }
        public string MessageID { get; set; }
        public string Email { get; set; }
        public long TelephoneNumber { get; set; }
        public string AdditionalProviderFilter { get; set; }
        public string ExternalReference { get; set; }
        public bool AP1WarningUnderstood { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }
        public string ApplicationAffects { get; set; }
        public bool Status { get; set; }
        public long RegistrationTypeId { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public long UserId { get; set; }
        public bool IsApiSuccess { get; set; }
        public int? OverallStatus { get; set; }

        [JsonIgnore]
        internal User User { get; set; }


        public ICollection<TitleNumber> Titles { get; set; }
        public ICollection<ApplicationForm> Applications { get; set; }
        public ICollection<SupportingDocuments> SupportingDocuments { get; set; }
        public ICollection<Representation> Representations { get; set; }
        public ICollection<Party> Parties { get; set; }
        public ICollection<RequestLog> RequestLogs { get; set; }
        public ICollection<Outstanding> Outstanding { get; set; }

    }

    public class Document
    {
        

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

        [JsonIgnore]
        internal ApplicationForm ApplicationForm { get; set; }

    }
}
