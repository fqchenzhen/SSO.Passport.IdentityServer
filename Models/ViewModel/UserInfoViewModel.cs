﻿using System;

namespace Models.ViewModel
{
    public class UserInfoViewModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime? LastLoginTime { get; set; }
    }
}