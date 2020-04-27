using System.Collections.Generic;
using System.Collections.Immutable;

namespace Fan.Abp.Dimensions
{
    public class DimensionValueGroup
    {
        /// <summary>
        /// or /and
        /// </summary>
        public string Operation { get; set; }

        private readonly List<DimensionValue> _dimensionValues;

        public DimensionValueGroup(List<DimensionValue> dimensionValues)
        {
            _dimensionValues = dimensionValues;
        }

        public IReadOnlyList<DimensionValue> DimensionValues => _dimensionValues.ToImmutableList();

        public DimensionValueGroup[] Children { get; set; }
    }
}
