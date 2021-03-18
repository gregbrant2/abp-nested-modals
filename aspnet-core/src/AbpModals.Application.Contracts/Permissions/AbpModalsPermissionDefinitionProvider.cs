using AbpModals.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpModals.Permissions
{
    public class AbpModalsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpModalsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpModalsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpModalsResource>(name);
        }
    }
}
