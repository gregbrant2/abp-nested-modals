using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace nested_modals
{
    [Dependency(ReplaceServices = true)]
    public class nested_modalsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "nested_modals";
    }
}
