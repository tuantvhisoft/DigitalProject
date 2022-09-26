using DS.Core.Configuration;
using DS.Core.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DS.Core.EF
{
    public class DsDbContext : IdentityDbContext<User, Role, string>
    {
        public DsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////Configure using Fluent API
        

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new InitialDetailConfiguration());
            modelBuilder.ApplyConfiguration(new InitialSignerConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new HsmInformationConfiguration());
            modelBuilder.ApplyConfiguration(new HSMExpireTimeConfiguration());
            modelBuilder.ApplyConfiguration(new SignerConfiguration());
            modelBuilder.ApplyConfiguration(new SignerDoctypeConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("AppEmpLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("AppEmpTokens").HasKey(x => x.UserId);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<ExternalSigner> ExternalSigners { get; set; }
        public DbSet<InitialDetail> InitialDetails { get; set; }
        public DbSet<InitialSigner> InitialSingers { get; set; }
        public DbSet<Status> Signers { get; set; }
        public DbSet<SignerDocType> SignerDocTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<HsmExpireTime> HsmExpireTimes { get; set; }
        public DbSet<HsmInformation> HsmInformations { get; set; }



    }
}
