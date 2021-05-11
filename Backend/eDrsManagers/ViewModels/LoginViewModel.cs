using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace eDrsManagers.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }        
        public string Password { get; set; }
    }
}
