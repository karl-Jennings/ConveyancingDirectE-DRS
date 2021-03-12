using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
   public class ErrorLogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ErrorLogId { get; set; }

        [StringLength(500)]
        public string ClassName { get; set; }

        [StringLength(int.MaxValue)]
        public string Message { get; set; }

        [StringLength(int.MaxValue)]
        public string Source { get; set; }

        [StringLength(int.MaxValue)]
        public string StackTraceString { get; set; }

        [Column(TypeName = "Datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
