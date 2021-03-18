using AbpModals.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpModals.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpModalsEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpModalsApplicationContractsModule)
        )]
    public class AbpModalsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
