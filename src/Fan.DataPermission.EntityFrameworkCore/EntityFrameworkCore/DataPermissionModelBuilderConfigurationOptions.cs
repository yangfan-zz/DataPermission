using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Fan.DataPermission.EntityFrameworkCore
{
    public class DataPermissionModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DataPermissionModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}