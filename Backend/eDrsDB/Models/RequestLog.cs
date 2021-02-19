using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class RequestLog
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RequestLogId { get; set; }
        public string Type { get; set; }
        public int TypeCode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string File { get; set; }
        public long DocumentReferenceId { get; set; }
        public DocumentReference DocumentReference { get; set; }
    }
}
