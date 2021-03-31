namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ErrorLog
    {
        public long ErrorLogId { get; set; }

        [StringLength(500)]
        public string ClassName { get; set; }

        public string Message { get; set; }

        public string Source { get; set; }

        public string StackTraceString { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
