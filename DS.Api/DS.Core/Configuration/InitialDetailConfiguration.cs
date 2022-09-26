using System;
using DS.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DS.Core.Configuration
{
    public class InitialDetailConfiguration : IEntityTypeConfiguration<InitialDetail>
    {
        public void Configure(EntityTypeBuilder<InitialDetail> builder)
        {
            builder.ToTable("InitialDetails");
            builder.HasKey(x => x.InitialDetailId);
            builder.Property(x => x.InitialDetailId).UseIdentityColumn();
            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.DetailStatus).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.InitialDetails).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.InitialSigner).WithMany(x => x.InitialDetails).HasForeignKey(x => x.InitialSignerId);
        }
    }
}

