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
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>

    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");

            builder.HasKey(x => x.DocID);
            builder.Property(x => x.DocID).UseIdentityColumn();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Author).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
        }
    }
}
