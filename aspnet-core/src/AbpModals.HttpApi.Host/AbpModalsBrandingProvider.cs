using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpModals
{
    [Dependency(ReplaceServices = true)]
    public class AbpModalsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpModals";
    }
}
