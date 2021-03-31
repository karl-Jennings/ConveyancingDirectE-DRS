namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentReference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentReference()
        {
            ApplicationForms = new HashSet<ApplicationForm>();
            Outstandings = new HashSet<Outstanding>();
            Parties = new HashSet<Party>();
            Representations = new HashSet<Representation>();
            RequestLogs = new HashSet<RequestLog>();
            SupportingDocuments = new HashSet<SupportingDocument>();
            TitleNumbers = new HashSet<TitleNumber>();
        }

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

        [Column(TypeName = "datetime2")]
        public DateTime ApplicationDate { get; set; }

        public bool DisclosableOveridingInterests { get; set; }

        public string PostcodeOfProperty { get; set; }

        public string LocalAuthority { get; set; }

        public string ApplicationAffects { get; set; }

        public bool Status { get; set; }

        public long RegistrationTypeId { get; set; }

        public long UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationForm> ApplicationForms { get; set; }

        public virtual RegistrationType RegistrationType { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outstanding> Outstandings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Party> Parties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representation> Representations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestLog> RequestLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportingDocument> SupportingDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleNumber> TitleNumbers { get; set; }
    }
}
