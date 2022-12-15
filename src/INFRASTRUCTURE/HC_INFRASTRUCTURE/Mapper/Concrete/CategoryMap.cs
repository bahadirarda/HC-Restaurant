using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class CategoryMap:BaseMap<Category>
	{
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired(true).HasMaxLength(96);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(3000);

            base.Configure(builder);
        }
    }
}

