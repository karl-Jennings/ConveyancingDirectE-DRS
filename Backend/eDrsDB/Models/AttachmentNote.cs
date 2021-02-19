using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class AttachmentNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AttachmentNotesId { get; set; }
        public string AdditionalProviderFilter { get; set; }
        public long MessageId { get; set; }
        public string ExternalReference { get; set; }
        public string ApplicationMessageId { get; set; }
        public string ApplicationService { get; set; }
        public string Notes { get; set; }
        public long DocumentReferenceId { get; set; }
        public DocumentReference DocumentReference { get; set; }
    }
}
