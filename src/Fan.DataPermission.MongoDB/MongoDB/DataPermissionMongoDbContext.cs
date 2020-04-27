using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Fan.DataPermission.MongoDB
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public class DataPermissionMongoDbContext : AbpMongoDbContext, IDataPermissionMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureDataPermission();
        }
    }
}