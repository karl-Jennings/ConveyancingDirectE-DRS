using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrsManagers.ViewModels
{
    public class ApplicationFormViewModel
    {
        public long ApplicationFormId { get; set; }
        public string Type { get; set; }
        public string Reference { get; set; }
        public DateTime ChargeDate { get; set; }

        public bool IsAgreed { get; set; }
        public string FileLocation { get; set; }
        public string FileName { get; set; }
        public string CertificationType { get; set; }
        public decimal Fee { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        public bool Status { get; set; }

        public long TitleNumberId { get; set; }
        public TitleNumberViewModel TitleNumber { get; set; }
    }
}
