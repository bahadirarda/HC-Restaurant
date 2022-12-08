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
    public class EmployeeSeed: IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = Guid.NewGuid(), FirstName = "Bahadır", LastName = "Arda", Title = "Boss"},
                new Employee { Id = Guid.NewGuid(), FirstName = "Erkut", LastName = "Kamis", Title = "Co-founder"},
                new Employee { Id = Guid.NewGuid(), FirstName = "Cagri", LastName = "Yolyapar", Title = "Teaching Master"},
                new Employee { Id = Guid.NewGuid(), FirstName = "Fatih", LastName = "Gunalp", Title = "Teaching master"}
                );
        }
    }
}
