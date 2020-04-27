using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Fan.DataPermission.MongoDB
{
    public class DataPermissionMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DataPermissionMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}