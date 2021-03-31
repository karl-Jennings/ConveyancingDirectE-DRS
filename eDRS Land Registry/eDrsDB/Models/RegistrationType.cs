namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistrationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistrationType()
        {
            DocumentReferences = new HashSet<DocumentReference>();
        }

        public long RegistrationTypeId { get; set; }

        [StringLength(150)]
        public string TypeName { get; set; }

        [StringLength(150)]
        public string TypeCode { get; set; }

        [StringLength(300)]
        public string Url { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentReference> DocumentReferences { get; set; }
    }
}
