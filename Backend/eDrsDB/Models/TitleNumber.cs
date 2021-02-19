using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class TitleNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TitleNumberId { get; set; }

        [StringLength(150)]
        public string TitleNumberCode { get; set; }
        public string LesseeTitleNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        public bool Status { get; set; }

        public long DocumentReferenceId { get; set; }
        public DocumentReference DocumentReference { get; set; }

    }
}
