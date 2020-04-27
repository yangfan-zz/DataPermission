using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(DataPermissionApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class DataPermissionHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "DataPermission";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(DataPermissionApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
