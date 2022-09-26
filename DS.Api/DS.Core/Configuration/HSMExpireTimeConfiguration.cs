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
    public class HSMExpireTimeConfiguration : IEntityTypeConfiguration<HsmExpireTime>

    {
        public void Configure(EntityTypeBuilder<HsmExpireTime> builder)
        {
            builder.ToTable("HsmExpireTimes");
            builder.HasKey(x => x.HsmExpireTimeId);
            builder.Property(x => x.HsmExpireTimeId).UseIdentityColumn();
            builder.Property(x => x.FromDateGet).IsRequired();
            builder.Property(x => x.ToDateExpire).IsRequired();
            builder.HasOne(x => x.HsmInformation).WithMany(x => x.HsmExpireTimes).HasForeignKey(x => x.HsmInId);
        }
    }
}
