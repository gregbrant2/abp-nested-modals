using System;
using System.Collections.Generic;
using System.Text;
using AbpModals.Localization;
using Volo.Abp.Application.Services;

namespace AbpModals
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpModalsAppService : ApplicationService
    {
        protected AbpModalsAppService()
        {
            LocalizationResource = typeof(AbpModalsResource);
        }
    }
}
