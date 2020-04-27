using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Fan.DataPermission.EntityFrameworkCore
{
    public static class DataPermissionDbContextModelCreatingExtensions
    {
        public static void ConfigureDataPermission(
            this ModelBuilder builder,
            Action<DataPermissionModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DataPermissionModelBuilderConfigurationOptions(
                DataPermissionDbProperties.DbTablePrefix,
                DataPermissionDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            // Configure all entities here. Example:

            builder.Entity<PermissionData>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "PermissionData", options.Schema);
            
                b.ConfigureByConvention();
                b.ConfigureExtraProperties();

                b.Property(x => x.Name).HasMaxLength(PermissionDataConsts.MaxNameLength).IsRequired();
                b.Property(x => x.ProviderName).HasMaxLength(PermissionDataConsts.MaxProviderNameLength).IsRequired();
                b.Property(x => x.ProviderKey).HasMaxLength(PermissionDataConsts.MaxProviderKeyLength).IsRequired();

                b.Property(x => x.Description).HasMaxLength(PermissionDataConsts.MaxDescriptionLength);

                b.HasIndex(x => new { x.Name, x.ProviderName, x.ProviderKey });

                b.Ignore(x => x.ItemGroup);
            });
           
        }
    }
}