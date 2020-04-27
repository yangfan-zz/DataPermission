using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Fan.DataPermission.MongoDB
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public interface IDataPermissionMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
