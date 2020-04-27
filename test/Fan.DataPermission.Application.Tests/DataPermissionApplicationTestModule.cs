using Volo.Abp.Modularity;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(DataPermissionApplicationModule),
        typeof(DataPermissionDomainTestModule)
        )]
    public class DataPermissionApplicationTestModule : AbpModule
    {

    }
}
