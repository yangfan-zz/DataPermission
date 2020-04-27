namespace Fan.Abp.Dimensions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDimensionDefinitionContext
    {
        DimensionDefinition GetOrNull(string name);

        void Add(params DimensionDefinition[] definitions);
    }
}
