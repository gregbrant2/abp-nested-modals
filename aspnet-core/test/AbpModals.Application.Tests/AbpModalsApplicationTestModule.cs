using Volo.Abp.Modularity;

namespace AbpModals
{
    [DependsOn(
        typeof(AbpModalsApplicationModule),
        typeof(AbpModalsDomainTestModule)
        )]
    public class AbpModalsApplicationTestModule : AbpModule
    {

    }
}