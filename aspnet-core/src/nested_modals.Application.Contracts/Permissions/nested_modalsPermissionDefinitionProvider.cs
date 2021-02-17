using nested_modals.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace nested_modals.Permissions
{
    public class nested_modalsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(nested_modalsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(nested_modalsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<nested_modalsResource>(name);
        }
    }
}
