namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Party
    {
        public long PartyId { get; set; }

        public bool IsApplicant { get; set; }

        public string CompanyOrForeName { get; set; }

        public string Surname { get; set; }

        public string Roles { get; set; }

        public string PartyType { get; set; }

        public string AddressForService { get; set; }

        public long DocumentReferenceId { get; set; }

        public virtual DocumentReference DocumentReference { get; set; }
    }
}
