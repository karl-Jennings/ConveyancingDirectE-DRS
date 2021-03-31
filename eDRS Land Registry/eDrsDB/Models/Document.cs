namespace eDrsDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Document
    {
        public long DocumentId { get; set; }

        public string Base64 { get; set; }

        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public long ApplicationFormId { get; set; }

        public long AttachmentId { get; set; }

        public virtual ApplicationForm ApplicationForm { get; set; }
    }
}
