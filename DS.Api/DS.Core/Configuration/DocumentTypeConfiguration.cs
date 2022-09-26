using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("DocumentTypes");
            builder.HasKey(x => x.DocumentTypeId);
            builder.Property(x => x.DocumentTypeId).UseIdentityColumn();
            builder.Property(x => x.DocumentTypeName).HasMaxLength(250);
            builder.Property(x => x.Temple).HasMaxLength(250);
        }
    }
}

