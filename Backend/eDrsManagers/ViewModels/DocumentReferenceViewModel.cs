using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using eDrsDB.Models;


namespace eDrsManagers.ViewModels
{
    public class DocumentReferenceViewModel
    {
        public long DocumentReferenceId { get; set; }

        [Required]
        public string Password { get; set; }
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
        public ICollection<RequestLog> RequestLogs { get; set; }
        public ICollection<Outstanding> Outstanding { get; set; }
        public bool IsApiSuccess { get; set; }


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
}
