using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class OrderMap:BaseMap<Order>
	{
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Employee).WithMany(x => x.Orders).HasForeignKey(x => x.EmployeeId);

            base.Configure(builder);
        }
    }
}

