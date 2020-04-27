using System;
using System.Collections.Generic;
using Fan.Abp.Dimensions;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;

namespace Fan.DataPermission
{
    /// <summary>
    /// 权限的数据
    /// </summary>
    public sealed class PermissionData : Entity<Guid>, IHasExtraProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PermissionData() => ExtraProperties = new Dictionary<string, object>();

        public PermissionData(Guid id, string name, [NotNull] string providerName,
            [CanBeNull] string providerKey) : this()
        {
            Check.NotNull(name, nameof(name));

            Id = id;
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            ProviderName = Check.NotNullOrWhiteSpace(providerName, nameof(providerName));
            ProviderKey = providerKey;
        }


        /// <summary>
        /// 权限名称
        /// </summary>
        [NotNull]
        public string Name { get; }

        #region Provider

        /// <summary>
        /// 
        /// </summary>
        [NotNull]
        public string ProviderName { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [CanBeNull]
        public string ProviderKey { get; protected internal set; }

        #endregion


        public DimensionValueGroup ItemGroup => this.GetProperty<DimensionValueGroup>(nameof(ItemGroup));

        public void SetItemGroup(DimensionValueGroup value) => this.SetProperty(nameof(ItemGroup), value);


        /// <summary>
        /// 启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 权限描述
        /// </summary>
        public string Description { get; set; }

        public Dictionary<string, object> ExtraProperties { get; }
    }
}
