﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string? Email { get; set; }
       
        public string Password { get; set; }
     
        public bool IsEmployeed { get; set; } = false;
    }
}
