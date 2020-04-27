using Fan.DataPermission.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Fan.DataPermission.Authorization
{
    public class DataPermissionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(DataPermissionPermissions.GroupName, L("Permission:DataPermission"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataPermissionResource>(name);
        }
    }
}