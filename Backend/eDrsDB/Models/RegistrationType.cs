using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class RegistrationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RegistrationTypeId { get; set; }

        [StringLength(150)]
        public string TypeName { get; set; }

        [StringLength(150)]
        public string TypeCode{ get; set; }

        [StringLength(300)]
        public string Url{ get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
