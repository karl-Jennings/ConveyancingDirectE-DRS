namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TitleNumber
    {
        public long TitleNumberId { get; set; }

        [StringLength(150)]
        public string TitleNumberCode { get; set; }

        public string LesseeTitleNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }

        public long DocumentReferenceId { get; set; }

        public virtual DocumentReference DocumentReference { get; set; }
    }
}
