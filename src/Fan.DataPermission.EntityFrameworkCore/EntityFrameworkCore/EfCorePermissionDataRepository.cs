using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Fan.DataPermission.EntityFrameworkCore
{
    public class EfCorePermissionDataRepository : EfCoreRepository<IDataPermissionDbContext, PermissionData, Guid>, IPermissionDataRepository
    {
        public EfCorePermissionDataRepository(IDbContextProvider<IDataPermissionDbContext> dbContextProvider) : base(
            dbContextProvider)
        {

        }

        public virtual async Task<PermissionData> FindAsync(string name, string providerName, string providerKey, CancellationToken cancellationToken = default)
        {
            return await DbSet
                .FirstOrDefaultAsync(s =>
                        s.Name == name &&
                        s.ProviderName == providerName &&
                        s.ProviderKey == providerKey,
                    GetCancellationToken(cancellationToken)
                );
        }

        public virtual async Task<List<PermissionData>> GetListAsync(string providerName, string providerKey, CancellationToken cancellationToken = default)
        {
            return await DbSet
                .Where(s =>
                    s.ProviderName == providerName &&
                    s.ProviderKey == providerKey
                ).ToListAsync(GetCancellationToken(cancellationToken));
        }
    }
}
