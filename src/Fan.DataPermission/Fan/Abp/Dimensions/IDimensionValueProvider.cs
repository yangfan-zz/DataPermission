using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Fan.Abp.Dimensions
{
    public interface IDimensionValueProvider
    {

        string Name { get; }

        Task<string> GetOrNullAsync([NotNull] DimensionDefinition dimension);
    }
}
