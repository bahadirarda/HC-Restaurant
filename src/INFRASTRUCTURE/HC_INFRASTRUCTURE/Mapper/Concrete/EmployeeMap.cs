using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class EmployeeMap:BaseMap<Employee>
	{
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired(true).HasMaxLength(16);
            builder.Property(x => x.LastName).IsRequired(true).HasMaxLength(16);
            builder.Property(x => x.Title).IsRequired(true).HasMaxLength(16);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(100);

            //İlişkilendirme - Departmant ile Employees classlarının ForeingKey ile birbirine bağlama
            builder.HasOne(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId);
            

            base.Configure(builder);

        }

    }
}

