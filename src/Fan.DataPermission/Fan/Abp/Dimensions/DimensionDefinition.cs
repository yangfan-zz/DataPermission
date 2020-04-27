namespace Fan.Abp.Dimensions
{
    public class DimensionDefinition
    {
        /// <summary>
        /// 维度名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        public DimensionDefinition(string name, string displayName, string description)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
        }
    }
}
