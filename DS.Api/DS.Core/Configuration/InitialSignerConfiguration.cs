using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class InitialSignerConfiguration :IEntityTypeConfiguration<InitialSigner>
    {
        public void Configure(EntityTypeBuilder<InitialSigner> builder)
        {
            builder.ToTable("InitialSigners");
            builder.HasKey(x => x.InitialSignerId);
            builder.Property(x => x.InitialSignerId).UseIdentityColumn();
            builder.Property(x => x.InSignerStatus).HasMaxLength(250).IsRequired();
        }
    }
}

