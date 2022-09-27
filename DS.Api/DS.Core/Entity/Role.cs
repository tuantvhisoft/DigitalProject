using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class Role : IdentityRole<string>
    {

        public string? Description { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
