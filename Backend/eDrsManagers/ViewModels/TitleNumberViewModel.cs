using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrsManagers.ViewModels
{
    public class TitleNumberViewModel
    {
        public long TitleNumberId { get; set; }
        public string TitleNumberCode { get; set; }
        public string PropertyName { get; set; }
        public string TitleType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Status { get; set; }
        public long DocumentReferenceId { get; set; }
        public DocumentReferenceViewModel DocumentReference { get; set; }

    }
}
