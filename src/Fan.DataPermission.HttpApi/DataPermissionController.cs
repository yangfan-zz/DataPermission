using Fan.DataPermission.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Fan.DataPermission
{
    public abstract class DataPermissionController : AbpController
    {
        protected DataPermissionController()
        {
            LocalizationResource = typeof(DataPermissionResource);
        }
    }
}
