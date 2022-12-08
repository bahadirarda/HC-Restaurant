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
    public class ProductSeed: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = Guid.NewGuid(), ProductName = "Tost", Description = "Leziz sucuklu ve kaşarlı eski usül tost", Price = 15.00m, Stock =  20 },
            new Product { Id = Guid.NewGuid(), ProductName = "Ayran", Description = "Susurluk ayranı", Price = 7.50m, Stock = 30},
            new Product { Id = Guid.NewGuid(), ProductName = "Karanfil Çayı", Description = "Çayın daha önce tatmadığınız güzellikte hali", Price = 25.75m, Stock = 50 },
            new Product { Id = Guid.NewGuid(), ProductName = "Test Data", Description = "Test Data", Price = 100.00m, Stock = 500 }

        );
        }
    }
}
