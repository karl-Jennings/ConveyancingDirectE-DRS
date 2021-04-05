using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text; 

namespace eDrsDB.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [Required, StringLength(150)]
        public string Username { get; set; }

        [Required, StringLength(150)]
        public string Firstname { get; set; }

        [StringLength(150)]
        public string Lastname { get; set; }

        [StringLength(350)]
        public string Email { get; set; }

        [Required]
        public string Designation { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [Required]
        public bool Status { get; set; }

        public ICollection<DocumentReference> DocumentReferences { get; set; }


    }
}
