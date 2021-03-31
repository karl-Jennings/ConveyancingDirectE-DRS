namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LrCredential
    {
        [Key]
        public long LrCredentialsId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
