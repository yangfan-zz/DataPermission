using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public interface IDataPermissionDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}