using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Fan.DataPermission
{
    /// <summary>
    /// 维度值
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class DimensionValue<TValue> : NameValue<TValue>
    {
        public DimensionValue()
        {

        }

        public DimensionValue(string name, TValue value)
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
