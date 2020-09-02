﻿using System;
namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PassworldHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
