using Volo.Abp.DependencyInjection;

namespace Fan.DataPermission
{
    public abstract class DimensionDefinitionProvider : IDimensionDefinitionProvider, ITransientDependency
    {
        public abstract void Define(IDimensionDefinitionContext context);
    }
}
