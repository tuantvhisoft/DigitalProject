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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Id).HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()");
            builder.HasIndex(x => x.PhoneNumber).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TaxCode).HasMaxLength(250);
            builder.Property(x => x.ImageUrl).HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.AccessKey).IsRequired();
            builder.Property(x => x.SecretKey).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("varchar(max)");
            builder.Property(x => x.PasswordSalt).IsRequired().HasColumnType("varchar(max)");
            builder.Property(x => x.IsBlocked).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
