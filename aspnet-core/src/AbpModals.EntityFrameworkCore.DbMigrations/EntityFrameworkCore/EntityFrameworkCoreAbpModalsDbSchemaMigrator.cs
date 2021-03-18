using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpModals.Data;
using Volo.Abp.DependencyInjection;

namespace AbpModals.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpModalsDbSchemaMigrator
        : IAbpModalsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpModalsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpModalsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpModalsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}