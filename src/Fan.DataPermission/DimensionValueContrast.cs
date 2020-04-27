namespace Fan.DataPermission
{
    public enum DimensionValueContrast
    {
        /// <summary>
        /// 对该值忽略
        /// </summary>
        Ignore,

        /// <summary>
        /// 该数据范围没有数据 常规处理需要范围空
        /// </summary>
        Null,

        /// <summary>
        /// 该数据范围没有数据 常规处理需要范围空
        /// </summary>
        Equal,

        /// <summary>
        /// 
        /// </summary>
        All = 999,
    }
}
