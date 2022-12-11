using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class SubCategoryMap: BaseMap<SubCategory>
	{
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SubCategoryName).IsRequired(true).HasMaxLength(300);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(3000);

            builder.HasOne(x => x.Category).WithMany(x => x.SubCategories).HasForeignKey(x => x.CategoryId);

            base.Configure(builder);
        }

    }
}

