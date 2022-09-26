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
    public class SignerConfiguration : IEntityTypeConfiguration<Signer>

    {
        public void Configure(EntityTypeBuilder<Signer> builder)
        {
            builder.ToTable("Signers");
            builder.HasKey(x => x.SignerId);
            builder.Property(x => x.SignerId).UseIdentityColumn();
            builder.Property(x => x.Status).HasMaxLength(250);
            builder.Property(x => x.InWidth).IsRequired();
            builder.Property(x => x.InHeight).IsRequired();
            builder.Property(x => x.InXsignPos).IsRequired();
            builder.Property(x => x.InYsignPos).IsRequired();
            builder.HasOne(x => x.Document).WithMany(x => x.Signers).HasForeignKey(x => x.DocumentId);
            builder.HasOne(x => x.User).WithMany(x => x.Signers).HasForeignKey(x => x.UserId);
            builder.HasOne<InitialSigner>(x => x.InitialSigner).WithOne(x => x.Signer).HasForeignKey<Signer>(x => x.InitialSignerId);
        }
    }
}
