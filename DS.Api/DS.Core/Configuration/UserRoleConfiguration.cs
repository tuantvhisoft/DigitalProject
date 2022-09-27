
using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");
            //builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            //builder.Property(x => x.TaxCode).HasMaxLength(250);
            //builder.Property(x => x.ImageUrl).HasMaxLength(250);
            //builder.Property(x => x.IsActive).IsRequired();
            //builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}

