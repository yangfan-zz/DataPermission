using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    [ConnectionStringName(DataPermissionDbProperties.ConnectionStringName)]
    public interface IDataPermissionDbContext : IEfCoreDbContext
    {
        DbSet<PermissionData> PermissionGrants { get;  }
    }
}