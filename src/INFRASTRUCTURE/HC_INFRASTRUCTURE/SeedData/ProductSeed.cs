using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Entities.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.SeedData
{
    public class ProductSeed: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = Guid.NewGuid(), ProductName = "Maki Sushi", Description = "Maki sushi is a sushi roll with the seaweed.", UnitPrice = 10.99m, UnitsInStock = 250},
                new Product { Id = Guid.NewGuid(), ProductName = "Maki Hoso", Description = "Boiling vegetables, serving with special hot sauce", UnitPrice = 8.99m, UnitsInStock = 300}
                );
        }
    }
}
