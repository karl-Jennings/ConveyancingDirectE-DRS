﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class Party
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PartyId { get; set; }

        public bool IsApplicant { get; set; }
        public string CompanyOrForeName { get; set; }
        public string Surname { get; set; }
        public string Roles { get; set; }
        public List<string> ViewModelRoles { get; set; }
        public string PartyType { get; set; }

        public long DocumentReferenceId { get; set; }
        public DocumentReference DocumentReference { get; set; }
    }
}
