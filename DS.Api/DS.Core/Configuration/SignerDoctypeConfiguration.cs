using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class SignerDoctypeConfiguration : IEntityTypeConfiguration<SignerDocType>
    {
        public void Configure(EntityTypeBuilder<SignerDocType> builder)
        {
            builder.ToTable("SignerDocTypes");
            builder.HasKey(x => x.SignerDocTypeId);
            builder.Property(x => x.SignerDocTypeId).UseIdentityColumn();
            builder.Property(x => x.Description);
            builder.HasOne(x => x.User).WithMany(x => x.SignerDocTypes).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.DocumentType).WithMany(x => x.SignerDocTypes).HasForeignKey(x => x.DocumentTypeId);
        }
    }
}

