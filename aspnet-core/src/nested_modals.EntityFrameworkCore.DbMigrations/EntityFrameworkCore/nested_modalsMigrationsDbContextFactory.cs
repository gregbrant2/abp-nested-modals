using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace nested_modals.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class nested_modalsMigrationsDbContextFactory : IDesignTimeDbContextFactory<nested_modalsMigrationsDbContext>
    {
        public nested_modalsMigrationsDbContext CreateDbContext(string[] args)
        {
            nested_modalsEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<nested_modalsMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new nested_modalsMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../nested_modals.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
