namespace Fan.Abp.DataPermission
{

    public class PermissionDataItemGroup
    {
        /// <summary>
        /// or /and
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PermissionDataItem[] Filters;

        /// <summary>
        /// 
        /// </summary>
        public PermissionDataItemGroup[] Children { get; set; }
    }
}
