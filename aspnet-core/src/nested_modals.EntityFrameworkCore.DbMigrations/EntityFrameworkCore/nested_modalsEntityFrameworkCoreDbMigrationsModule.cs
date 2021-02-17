using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace nested_modals.EntityFrameworkCore
{
    [DependsOn(
        typeof(nested_modalsEntityFrameworkCoreModule)
        )]
    public class nested_modalsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<nested_modalsMigrationsDbContext>();
        }
    }
}
