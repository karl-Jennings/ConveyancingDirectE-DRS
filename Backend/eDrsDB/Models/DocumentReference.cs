using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class DocumentReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DocumentReferenceId { get; set; }
        public string Reference { get; set; }
        public int TotalFeeInPence { get; set; }
        public string MessageID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long TelephoneNumber { get; set; }
        public string AdditionalProviderFilter { get; set; }
        public string ExternalReference { get; set; }
        public bool AP1WarningUnderstood { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }
        public string Notes { get; set; }
        public string ApplicationAffects { get; set; }
        public bool Status { get; set; }
        public long RegistrationTypeId { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public long UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }


        public ICollection<TitleNumber> Titles { get; set; }
        public ICollection<ApplicationForm> Applications { get; set; }
        public ICollection<SupportingDocuments> SupportingDocuments { get; set; }
        public ICollection<Representation> Representations { get; set; }
        public ICollection<Party> Parties { get; set; }
        public ICollection<AttachmentNote> AttachmentNotes { get; set; }
        public ICollection<RequestLog> RequestLogs { get; set; }

    }
}
