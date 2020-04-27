using Fan.Abp.Dimensions;
using Volo.Abp;

namespace Fan.Abp.DataPermission
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionDataItem : NameValue<string>
    {
        public PermissionDataItem()
        {

        }

        public PermissionDataItem(string name, string value)
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
