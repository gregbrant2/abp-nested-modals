using nested_modals.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace nested_modals.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class nested_modalsController : AbpController
    {
        protected nested_modalsController()
        {
            LocalizationResource = typeof(nested_modalsResource);
        }
    }
}