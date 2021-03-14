using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eDrsDB.Models
{
    public class User
    {
          public long UserId { get; set; }

         public string Username { get; set; }

         public string Firstname { get; set; }

         public string Lastname { get; set; }

         public string Email { get; set; }

         public string Designation { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

         public bool Status { get; set; }

 

    }
}
