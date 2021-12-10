﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using eDRS_Land_Registry.Models;
namespace eDrsDB.Models
{
    public class Party
    {
         public long PartyId { get; set; }

        public bool IsApplicant { get; set; }
        public string CompanyOrForeName { get; set; }
        public string Surname { get; set; }
        public string Roles { get; set; }
        public List<string> ViewModelRoles { get; set; }
        public string PartyType { get; set; }
        public List<AddressForService> AddressForService { get; set; }

        public long DocumentReferenceId { get; set; }
     }
}
