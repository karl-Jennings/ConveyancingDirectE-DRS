using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class SupportingDocuments
    {
         public long SupportingDocumentId { get; set; }

        public string CertifiedCopy { get; set; }
        public string DocumentId { get; set; }
        public string DocumentName { get; set; }

        public long DocumentReferenceId { get; set; }
 
    }
}
