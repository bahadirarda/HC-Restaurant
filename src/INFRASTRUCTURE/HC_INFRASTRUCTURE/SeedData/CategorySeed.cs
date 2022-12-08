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
    public class CategorySeed: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) 
        {
            builder.HasData(
              new Category { Id = Guid.NewGuid(), CategoryName = "East Asian", Description = "Asian food is good" },
              new Category { Id = Guid.NewGuid(), CategoryName = "Turkish", Description = "Turkish food is good" },
              new Category { Id = Guid.NewGuid(), CategoryName = "Global", Description = "Global food is good" }
              );
        }
    }
}
