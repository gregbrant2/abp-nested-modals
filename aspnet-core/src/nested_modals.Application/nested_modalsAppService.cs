using System;
using System.Collections.Generic;
using System.Text;
using nested_modals.Localization;
using Volo.Abp.Application.Services;

namespace nested_modals
{
    /* Inherit your application services from this class.
     */
    public abstract class nested_modalsAppService : ApplicationService
    {
        protected nested_modalsAppService()
        {
            LocalizationResource = typeof(nested_modalsResource);
        }
    }
}
