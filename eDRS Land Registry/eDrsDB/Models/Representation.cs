namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Representation
    {
        public long RepresentationId { get; set; }

        public string Type { get; set; }

        public long RepresentativeId { get; set; }

        public string Name { get; set; }

        public string Reference { get; set; }

        public string AddressType { get; set; }

        public long DocumentReferenceId { get; set; }

        public string CareOfName { get; set; }

        public string CareOfReference { get; set; }

        public long DxNumber { get; set; }

        public string DxExchange { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressLine4 { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }

        public virtual DocumentReference DocumentReference { get; set; }
    }
}
