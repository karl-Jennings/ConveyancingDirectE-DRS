using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eDrsDB.Models;

namespace eDrsManagers.ViewModels
{
    public class DocumentReferenceViewModel
    {
        public long DocumentReferenceId { get; set; }
        public string ReferenceName { get; set; }

        public string ReferenceCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string Email { get; set; }

        public string Notes { get; set; }

        public bool Status { get; set; }

        public long UserId { get; set; }
        public UserViewModel User { get; set; }

        public long RegistrationTypeId { get; set; }
        public ICollection<TitleNumber> TitleNumbers { get; set; }


    }
}
