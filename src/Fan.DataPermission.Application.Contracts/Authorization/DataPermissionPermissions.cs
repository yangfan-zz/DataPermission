using Volo.Abp.Reflection;

namespace Fan.DataPermission.Authorization
{
    public class DataPermissionPermissions
    {
        public const string GroupName = "DataPermission";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DataPermissionPermissions));
        }
    }
}