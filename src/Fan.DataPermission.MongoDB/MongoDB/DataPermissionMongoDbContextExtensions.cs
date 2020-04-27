using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Fan.DataPermission.MongoDB
{
    public static class DataPermissionMongoDbContextExtensions
    {
        public static void ConfigureDataPermission(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DataPermissionMongoModelBuilderConfigurationOptions(
                DataPermissionDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}