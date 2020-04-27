using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public class DataPermissionDbContext : AbpDbContext<DataPermissionDbContext>, IDataPermissionDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

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