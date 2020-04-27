using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities;

namespace Fan.DataPermission
{
    /// <summary>
    /// 权限的数据
    /// </summary>
    public class PermissionData : Entity<Guid>
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        [NotNull]
        public virtual string Name { get; protected set; }

        #region Provider 

        /// <summary>
        /// 
        /// </summary>
        [NotNull]
        public virtual string ProviderName { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [CanBeNull]
        public virtual string ProviderKey { get; protected internal set; }

        #endregion

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }



        /// <summary>
        /// 权限描述
        /// </summary>
        public string Description { get; set; }
    }
}
