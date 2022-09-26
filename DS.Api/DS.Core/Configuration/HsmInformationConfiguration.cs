using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class HsmInformationConfiguration : IEntityTypeConfiguration<HsmInformation>
    {
        
        public void Configure(EntityTypeBuilder<HsmInformation> builder)
        {
            builder.ToTable("HsmInformations");
            builder.HasKey(x => x.HsmInId);
            builder.Property(x => x.HsmInId).UseIdentityColumn();
            builder.Property(x => x.IdentityCard).HasMaxLength(250).IsRequired();
            builder.Property(x => x.TokenHsm).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.HsmInformation).HasForeignKey(x => x.UserId);
        }
    }
}

