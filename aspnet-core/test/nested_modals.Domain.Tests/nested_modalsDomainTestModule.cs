using nested_modals.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace nested_modals
{
    [DependsOn(
        typeof(nested_modalsEntityFrameworkCoreTestModule)
        )]
    public class nested_modalsDomainTestModule : AbpModule
    {

    }
}