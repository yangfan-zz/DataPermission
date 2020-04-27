using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(DataPermissionHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DataPermissionConsoleApiClientModule : AbpModule
    {
        
    }
}
