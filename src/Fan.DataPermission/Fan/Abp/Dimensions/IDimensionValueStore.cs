using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Fan.Abp.Dimensions
{
    public interface IDimensionValueStore
    {
        Task<string> GetOrNullAsync(
            [NotNull] string name,
            [CanBeNull] string providerName,
            [CanBeNull] string providerKey
        );
    }
}
