using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class TitleNumber
    {

       
        public long TitleNumberId { get; set; }

        public string TitleNumberCode { get; set; }       
        public string LesseeTitleNumber { get; set; }
        public string AdditionalTitles { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }

        public long DocumentReferenceId { get; set; }

    }
}
