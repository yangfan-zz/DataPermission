namespace Fan.Abp.Dimensions
{
    public class DimensionValueGroup
    {
        /// <summary>
        /// or /and
        /// </summary>
        public string Operation { get; set; }

        public DimensionValue[] Values { get; set; }

        public DimensionValueGroup[] Children { get; set; }
    }
}
