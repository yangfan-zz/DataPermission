using Volo.Abp.DependencyInjection;

namespace Fan.Abp.Dimensions
{
    public abstract class DimensionDefinitionProvider : IDimensionDefinitionProvider, ITransientDependency
    {
        public abstract void Define(IDimensionDefinitionContext context);
    }
}
