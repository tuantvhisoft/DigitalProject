﻿using System;
using Microsoft.AspNetCore.Identity;

namespace DS.Core.Entity
{
    public class UserRole : BaseEntity
    {
        public string? UserId { get; set; }
        public string? RoleId { get; set; }
        public virtual User? User { get; set; }
        public virtual Role? Role { get; set; }
    }
}

