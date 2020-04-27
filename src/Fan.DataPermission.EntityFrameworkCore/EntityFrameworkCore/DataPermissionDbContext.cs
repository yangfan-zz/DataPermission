using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public class DataPermissionDbContext : AbpDbContext<DataPermissionDbContext>, IDataPermissionDbContext
    {
        public DbSet<PermissionData> PermissionGrants { get; set; }

        public DataPermissionDbContext(DbContextOptions<DataPermissionDbContext> options) 
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDataPermission();
        }


    }
}