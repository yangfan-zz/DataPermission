using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Fan.Abp.Dimensions
{
    public abstract class DimensionValueProvider : IDimensionValueProvider, ITransientDependency
    {
        public abstract string Name { get; }

        protected IDimensionValueStore DimensionValueStore { get; }

        protected DimensionValueProvider(IDimensionValueStore dimensionValueStore)
        {
            DimensionValueStore = dimensionValueStore;
        }

        public abstract Task<string> GetOrNullAsync(DimensionDefinition dimension);
    }
}
