namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Outstanding")]
    public partial class Outstanding
    {
        public long OutstandingId { get; set; }

        public string LandRegistryId { get; set; }

        public string ServiceType { get; set; }

        public bool NewResponse { get; set; }

        public int TypeCode { get; set; }

        public string Type { get; set; }

        public long DocumentReferenceId { get; set; }

        public virtual DocumentReference DocumentReference { get; set; }
    }
}
