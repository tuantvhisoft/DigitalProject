using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DS.Core.EF
{
    public class DsDbContextFactory : IDesignTimeDbContextFactory<DsDbContext>
    {
        public DsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DsDb");
            var optionBuilder = new DbContextOptionsBuilder<DsDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new DsDbContext(optionBuilder.Options);
        }
    }
}
