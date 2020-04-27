using System.Collections.Generic;
using System.Collections.Immutable;

namespace Fan.DataPermission
{
    /// <summary>
    /// 维度定义的上下文
    /// </summary>
    public class DimensionDefinitionContext : IDimensionDefinitionContext
    {
        protected Dictionary<string, DimensionDefinition> Dimensions { get; }

        public DimensionDefinitionContext(Dictionary<string, DimensionDefinition> settings)
        {
            Dimensions = settings;
        }


        public virtual DimensionDefinition GetOrNull(string name)
        {
            return Dimensions.GetOrDefault(name);
        }

        public virtual IReadOnlyList<DimensionDefinition> GetAll()
        {
            return Dimensions.Values.ToImmutableList();
        }

        public virtual void Add(params DimensionDefinition[] definitions)
        {
            if (definitions.IsNullOrEmpty())
            {
                return;
            }

            foreach (var definition in definitions)
            {
                Dimensions[definition.Name] = definition;
            }
        }
    }
}
