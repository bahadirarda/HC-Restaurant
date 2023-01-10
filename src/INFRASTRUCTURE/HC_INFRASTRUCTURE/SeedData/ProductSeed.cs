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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = Guid.NewGuid(), ProductName = "Maki Sushi", Description = "Maki sushi is a sushi roll with the seaweed.", Price = 10.99m, Stock = 250 },
                new Product { Id = Guid.NewGuid(), ProductName = "Maki Hoso", Description = "Boiling vegetables, serving with special hot sauce", Price = 8.99m, Stock = 300 },
                new Product { Id = Guid.NewGuid(), ProductName = "California Roll", Description = "A sushi roll filled with crab meat, avocado, and cucumber.", Price = 12.99m, Stock = 200 },
                new Product { Id = Guid.NewGuid(), ProductName = "Nigiri Sushi", Description = "Thin slices of raw fish served over a small ball of sushi rice.", Price = 15.99m, Stock = 150 },
                new Product { Id = Guid.NewGuid(), ProductName = "Ramen Noodle Soup", Description = "Japanese wheat noodle soup with a variety of toppings, such as sliced pork, dried seaweed, and green onions.", Price = 11.99m, Stock = 250 },
                new Product { Id = Guid.NewGuid(), ProductName = "Udon Noodle Soup", Description = "Japanese wheat noodle soup with a variety of toppings, such as tempura, seafood, and eggs.", Price = 13.99m, Stock = 200 },
                new Product { Id = Guid.NewGuid(), ProductName = "Tempura", Description = "Deep-fried seafood and vegetables, served with a special dipping sauce.", Price = 14.99m, Stock = 175 }
                );
        }
    }
}
