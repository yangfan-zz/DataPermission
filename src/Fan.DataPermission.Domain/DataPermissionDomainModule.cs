using Volo.Abp.Modularity;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(DataPermissionDomainSharedModule)
        )]
    public class DataPermissionDomainModule : AbpModule
    {

    }
}
