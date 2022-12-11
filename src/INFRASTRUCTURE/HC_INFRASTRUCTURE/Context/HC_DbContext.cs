using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Entities.Interface;
using HC_INFRASTRUCTURE.Mapper.Concrete;
using HC_INFRASTRUCTURE.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Context
{
    public class HC_DbContext : IdentityDbContext
    {
        public HC_DbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<AppUser> AppUsers;
        public DbSet<AppUserRole> AppUserRoles;
        public DbSet<Category> Categories;
        public DbSet<Department> Departments;
        public DbSet<Employee> Employees;
        public DbSet<Order> Orders;
        public DbSet<OrderDetail> OrderDetails;
        public DbSet<Product> Products;
        public DbSet<SubCategory> SubCategories;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new DepartmentMap());
            builder.ApplyConfiguration(new EmployeeMap());
            builder.ApplyConfiguration(new OrderMap());
            builder.ApplyConfiguration(new OrderDetailMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new SubCategoryMap());


            //SeedData Building
            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new DepartmentSeed());
            builder.ApplyConfiguration(new EmployeeSeed());
            builder.ApplyConfiguration(new ProductSeed());



            base.OnModelCreating(builder);
        }
        
        public override int SaveChanges()
        {

            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
         .Where(x => x.State == EntityState.Added)
         .Select(x => x.State)
         .ToArray();

            foreach (var entity in added)
            {
                if (entity is IBaseEntity)
                {
                    var track = entity as IBaseEntity;
                    track.CreatedDate = DateTime.Now;
                    track.CreatedBy = Id;
                }
            }

            var modified = this.ChangeTracker.Entries()
          .Where(x => x.Entity is IBaseEntity && x.State == EntityState.Modified)
          .Select(x => x.Entity)
          .ToArray();

            foreach (var entity in modified)
            {
                if (entity is IBaseEntity)
                {
                    var track = entity as IBaseEntity;
                    track.UpdatedDate = DateTime.Now;
                    track.UpdatedBy = Id;
                }
            }
            return base.SaveChanges();
        }
    }
}
