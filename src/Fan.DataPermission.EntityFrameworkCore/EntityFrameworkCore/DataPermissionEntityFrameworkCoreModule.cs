using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Fan.DataPermission.EntityFrameworkCore
{
    [DependsOn(
        typeof(DataPermissionDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DataPermissionEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DataPermissionDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}