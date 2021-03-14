using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrsDB.Models
{
    public class ApplicationForm
    {
        public long ApplicationFormId { get; set; }

        public string Variety { get; set; }
        public int Priority { get; set; }
        public string Value { get; set; }
        public int FeeInPence { get; set; }
        public string Type { get; set; }
        public string ExternalReference { get; set; }
        public string CertifiedCopy { get; set; }
        public DateTime ChargeDate { get; set; }
        public string MDRef { get; set; }

        public long DocumentReferenceId { get; set; }
        public Document Document { get; set; }

    }

    public class Document
    {
        public long DocumentId { get; set; }

        public string Base64 { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public long ApplicationFormId { get; set; }

    }
}