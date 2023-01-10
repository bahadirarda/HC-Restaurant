using System;
using HC_DOMAIN.Entities.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Abstract
{
        public abstract class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IBaseEntity
        {
            public virtual void Configure(EntityTypeBuilder<TEntity> builder)
            {
                builder.Property(x => x.Status).IsRequired(true);

                builder.Property(x => x.CreatedDate).IsRequired(false);
                builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(96);

                builder.Property(x => x.UpdatedDate).IsRequired(false);
                builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(96);

                builder.Property(x => x.DeletedDate).IsRequired(false);
                builder.Property(x => x.DeletedBy).IsRequired(false).HasMaxLength(96);
            }
        }
}
