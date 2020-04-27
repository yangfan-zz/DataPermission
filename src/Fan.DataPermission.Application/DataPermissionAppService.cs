using Fan.DataPermission.Localization;
using Volo.Abp.Application.Services;

namespace Fan.DataPermission
{
    public abstract class DataPermissionAppService : ApplicationService
    {
        protected DataPermissionAppService()
        {
            LocalizationResource = typeof(DataPermissionResource);
            ObjectMapperContext = typeof(DataPermissionApplicationModule);
        }
    }
}
