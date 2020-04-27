using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    public class DataPermissionHttpApiHostMigrationsDbContext : AbpDbContext<DataPermissionHttpApiHostMigrationsDbContext>
    {
        public DataPermissionHttpApiHostMigrationsDbContext(DbContextOptions<DataPermissionHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDataPermission();
        }
    }
}
