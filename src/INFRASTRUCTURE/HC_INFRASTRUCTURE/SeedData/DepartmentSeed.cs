using HC_DOMAIN.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.SeedData
{
    public class DepartmentSeed: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
               new Department { Id = Guid.NewGuid(), DepartmentName = "General management" },
               new Department { Id = Guid.NewGuid(), DepartmentName = "Purchase management" },
               new Department { Id = Guid.NewGuid(), DepartmentName = "Personal management" },
               new Department { Id = Guid.NewGuid(), DepartmentName = "Sales management" }
               );
        }
    }
}
