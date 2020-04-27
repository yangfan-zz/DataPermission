using Volo.Abp.Collections;

namespace Fan.Abp.Dimensions
{
    public class DimensionOptions
    {
        public ITypeList<IDimensionDefinitionProvider> DefinitionProviders { get; }

        public ITypeList<IDimensionValueProvider> ValueProviders { get; }

        public DimensionOptions()
        {
            DefinitionProviders = new TypeList<IDimensionDefinitionProvider>();
            ValueProviders = new TypeList<IDimensionValueProvider>();
        }
    }
}
