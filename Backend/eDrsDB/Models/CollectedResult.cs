using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace eDrsDB.Models
{
    public class CollectedResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ResultId { get; set; }
        public string MessageId { get; set; }
        public string AppMessageId { get; set; }
        public string ExternalReference { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }       
        public string RejectionReason { get; set; }
        public string ValidationErrors { get; set; }
        public string ResponseType { get; set; }
        public string ResponseJson { get; set; }       
        public bool IsSuccess { get; set; }        
        public string AttachmentName { get; set; }
        public string AttachmentId { get; set; }      
     
    }
}
