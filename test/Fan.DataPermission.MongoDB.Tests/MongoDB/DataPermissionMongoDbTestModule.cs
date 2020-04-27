using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Fan.DataPermission.MongoDB
{
    [DependsOn(
        typeof(DataPermissionTestBaseModule),
        typeof(DataPermissionMongoDbModule)
        )]
    public class DataPermissionMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}