using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class RegistrationType
    {
        public long RegistrationTypeId { get; set; }

        public string TypeName { get; set; }

        public string TypeCode { get; set; }

        public string Url { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }
    }
}
