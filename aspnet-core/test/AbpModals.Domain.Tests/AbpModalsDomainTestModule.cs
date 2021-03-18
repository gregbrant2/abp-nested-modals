using AbpModals.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpModals
{
    [DependsOn(
        typeof(AbpModalsEntityFrameworkCoreTestModule)
        )]
    public class AbpModalsDomainTestModule : AbpModule
    {

    }
}