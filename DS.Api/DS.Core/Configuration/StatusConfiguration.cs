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
    public class StatusConfiguration : IEntityTypeConfiguration<Status>

    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.HasKey(x => x.StatusID);
            builder.Property(x => x.StatusID).UseIdentityColumn();
            builder.Property(x => x.StatusName).HasMaxLength(250);
        }
    }
}
