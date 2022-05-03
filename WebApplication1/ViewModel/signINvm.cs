﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModel
{
    public class signINvm
    {
        [Required]
        public string UserNAme { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
