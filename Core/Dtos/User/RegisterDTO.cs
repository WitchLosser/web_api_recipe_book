﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.User
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Password { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        public string Location { get; set; }
    }
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
