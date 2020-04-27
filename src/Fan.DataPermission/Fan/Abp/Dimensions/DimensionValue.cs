using Volo.Abp;

namespace Fan.Abp.Dimensions
{
 
    /// <summary>
    /// 维度值
    /// </summary>
    public class DimensionValue : NameValue<string>
    {
        public DimensionValue()
        {

        }

        public DimensionValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DimensionValueContrast Contrast { get; set; }
    }
}
