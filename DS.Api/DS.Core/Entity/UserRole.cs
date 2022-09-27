﻿using System;
using Microsoft.AspNetCore.Identity;

namespace DS.Core.Entity
{
    public class UserRole : IdentityUserRole<string>
    {
        public string? UserId { get; set; }
        public string? RoleId { get; set; }
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}

