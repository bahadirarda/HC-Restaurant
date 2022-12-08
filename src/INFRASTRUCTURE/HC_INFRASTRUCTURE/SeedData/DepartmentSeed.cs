using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_DOMAIN.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.SeedData
{
    public class DepartmentSeed: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department { Id = Guid.NewGuid(), DepartmentName = "General Management Department" },
                new Department { Id = Guid.NewGuid(), DepartmentName = "Purchasing Management Department" },
                new Department { Id = Guid.NewGuid(), DepartmentName = "Sales Management Department" }, 
                new Department { Id = Guid.NewGuid(), DepartmentName = "Services Department"} // Includes service personnel
                );
        }
    }
}
