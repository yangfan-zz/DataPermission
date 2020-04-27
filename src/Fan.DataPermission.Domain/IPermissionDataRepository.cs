using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Fan.DataPermission
{
    /// <summary>
    /// 权限数据范围
    /// </summary>
    public interface IPermissionDataRepository : IBasicRepository<PermissionData, Guid>
    {
        Task<PermissionData> FindAsync(
            string name,
            string providerName,
            string providerKey,
            CancellationToken cancellationToken = default
        );

        Task<List<PermissionData>> GetListAsync(
            string providerName,
            string providerKey,
            CancellationToken cancellationToken = default
        );
    }
}
