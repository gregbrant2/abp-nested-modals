using Volo.Abp.Settings;

namespace nested_modals.Settings
{
    public class nested_modalsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(nested_modalsSettings.MySetting1));
        }
    }
}
