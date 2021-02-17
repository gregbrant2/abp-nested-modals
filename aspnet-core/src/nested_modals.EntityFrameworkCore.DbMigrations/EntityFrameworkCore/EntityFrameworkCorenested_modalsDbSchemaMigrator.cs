using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using nested_modals.Data;
using Volo.Abp.DependencyInjection;

namespace nested_modals.EntityFrameworkCore
{
    public class EntityFrameworkCorenested_modalsDbSchemaMigrator
        : Inested_modalsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorenested_modalsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the nested_modalsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<nested_modalsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}