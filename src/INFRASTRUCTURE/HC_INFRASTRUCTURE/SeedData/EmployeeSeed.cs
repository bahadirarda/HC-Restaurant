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
    public class EmployeeSeed : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
               new Employee { Id = Guid.NewGuid(), FirstName = "Bahadır", LastName = "Arda", Title = "Mr." },
               new Employee { Id = Guid.NewGuid(), FirstName = "Erkut", LastName = "Kamış", Title = "Mr." },
               new Employee { Id = Guid.NewGuid(), FirstName = "Çağrı", LastName = "Yolyapar", Title = "Mr." },
               new Employee { Id = Guid.NewGuid(), FirstName = "Fatih", LastName = "Günalp", Title = "Mr." }
               );
        }
    }
}
