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
    public class CategorySeed: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = Guid.NewGuid(), CategoryName = "TestCat1", Description = "Category Test Description" },
                new Category { Id = Guid.NewGuid(), CategoryName = "TestCat2", Description = "Category Test Description" },
                new Category { Id = Guid.NewGuid(), CategoryName = "TestCat3", Description = "Category Test Description" }
                );
        }
    }
}
