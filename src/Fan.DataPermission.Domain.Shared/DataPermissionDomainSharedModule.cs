using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Fan.DataPermission.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Fan.DataPermission
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class DataPermissionDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DataPermissionDomainSharedModule>("Fan.DataPermission");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<DataPermissionResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/DataPermission");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("DataPermission", typeof(DataPermissionResource));
            });
        }
    }
}
