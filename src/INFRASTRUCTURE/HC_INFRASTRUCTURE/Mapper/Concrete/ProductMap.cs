using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class ProductMap: BaseMap<Product>
	{
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductName).IsRequired(true).HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(3000);
            builder.Property(x => x.Price).IsRequired(true).HasPrecision(18, 2).HasConversion<decimal>();
            builder.Property(x => x.Stock).IsRequired(true).HasConversion<short>();

            builder.Property(x => x.ImagePath).IsRequired(false).HasMaxLength(1000);

            builder.HasOne(x => x.SubCategory).WithMany(x => x.Products).HasForeignKey(x => x.SubCategoryId);

            base.Configure(builder);
        }
    }
}

