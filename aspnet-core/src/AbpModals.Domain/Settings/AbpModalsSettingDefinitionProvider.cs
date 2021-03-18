using Volo.Abp.Settings;

namespace AbpModals.Settings
{
    public class AbpModalsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpModalsSettings.MySetting1));
        }
    }
}
