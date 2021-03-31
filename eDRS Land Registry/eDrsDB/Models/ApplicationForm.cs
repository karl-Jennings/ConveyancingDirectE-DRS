namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationForm()
        {
            Documents = new HashSet<Document>();
        }

        public long ApplicationFormId { get; set; }

        public string Variety { get; set; }

        public int Priority { get; set; }

        public string Value { get; set; }

        public int FeeInPence { get; set; }

        public string Type { get; set; }

        public string ExternalReference { get; set; }

        public string CertifiedCopy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ChargeDate { get; set; }

        public string IsMdRef { get; set; }

        public string SortCode { get; set; }

        public string MdRef { get; set; }

        public long DocumentReferenceId { get; set; }

        public bool IsChecked { get; set; }

        public virtual DocumentReference DocumentReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
