using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class Representation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RepresentationId { get; set; }

        public string Type { get; set; }
        public long RepresentativeId { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public long DxNumber { get; set; }
        public string DxExchange { get; set; }

        public long DocumentReferenceId { get; set; }
        public DocumentReference DocumentReference { get; set; }

    }
}
