using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace eDrsManagers.ViewModels
{
    public class UserViewModel
    {
        public long UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Status { get; set; }
        [JsonIgnore]
        internal virtual ICollection<DocumentReferenceViewModel> DocumentReferences { get; set; }
        public string Fullname { get; set; }
        public bool IsUserValid { get; set; }
        public string Token { get; set; }
    }
}
