﻿using System.ComponentModel.DataAnnotations;

namespace SFMvc.Views.Home
{
    public class LoginVM
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
