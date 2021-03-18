using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpModals.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpModalsEntityFrameworkCoreModule)
        )]
    public class AbpModalsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpModalsMigrationsDbContext>();
        }
    }
}
