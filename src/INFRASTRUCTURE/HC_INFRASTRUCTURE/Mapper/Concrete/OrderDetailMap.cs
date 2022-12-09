using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class OrderDetailMap: BaseMap<OrderDetail>
	{
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Price).HasPrecision(18, 2).HasConversion<Decimal>().IsRequired(true); //HasPrecision default value(18,2)

            builder.Property(x => x.Quantity).IsRequired(true);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);


            base.Configure(builder);
        }
    }
}

