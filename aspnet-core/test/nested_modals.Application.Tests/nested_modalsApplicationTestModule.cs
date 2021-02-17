using Volo.Abp.Modularity;

namespace nested_modals
{
    [DependsOn(
        typeof(nested_modalsApplicationModule),
        typeof(nested_modalsDomainTestModule)
        )]
    public class nested_modalsApplicationTestModule : AbpModule
    {

    }
}