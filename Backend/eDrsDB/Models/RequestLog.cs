using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text; 
using Newtonsoft.Json;

namespace eDrsDB.Models
{
    public class RequestLog
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RequestLogId { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string AppMessageId { get; set; }

        public string RejectionReason { get; set; }
        public string ValidationErrors { get; set; }

        public string ResponseType { get; set; }
        public string ResponseJson { get; set; }

        public long DocumentReferenceId { get; set; }

        [JsonIgnore]
        internal DocumentReference DocumentReference { get; set; }

        public bool IsSuccess { get; set; }
        public List<RequestLog> AttachmentResponse { get; set; }

        public string AttachmentName { get; set; }
        public string AttachmentId { get; set; }

    }
}
