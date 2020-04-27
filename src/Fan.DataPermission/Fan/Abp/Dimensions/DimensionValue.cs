﻿using System.Collections.Generic;
using System.Collections.Immutable;
using Volo.Abp;

namespace Fan.Abp.Dimensions
{
 
    /// <summary>
    /// 
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
