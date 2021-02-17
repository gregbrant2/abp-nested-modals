using nested_modals.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace nested_modals.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(nested_modalsEntityFrameworkCoreDbMigrationsModule),
        typeof(nested_modalsApplicationContractsModule)
        )]
    public class nested_modalsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
