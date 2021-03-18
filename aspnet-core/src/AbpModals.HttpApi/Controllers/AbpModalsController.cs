using AbpModals.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpModals.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpModalsController : AbpController
    {
        protected AbpModalsController()
        {
            LocalizationResource = typeof(AbpModalsResource);
        }
    }
}