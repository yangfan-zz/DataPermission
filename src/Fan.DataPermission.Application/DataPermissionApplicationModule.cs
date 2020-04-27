using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(DataPermissionDomainModule),
        typeof(DataPermissionApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DataPermissionApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<DataPermissionApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DataPermissionApplicationModule>(validate: true);
            });
        }
    }
}
