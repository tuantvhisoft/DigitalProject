using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Configuration
{
    public class UserConfiguration
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TaxCode).HasMaxLength(250);
            builder.Property(x => x.ImageUrl).HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
