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
            builder.ApplyConfiguration(new EmployeeSeed());
            builder.ApplyConfiguration(new DepartmentSeed());
            
            //builder.ApplyConfiguration(new ProductSeed());



            base.OnModelCreating(builder);
        }
        
        public override int SaveChanges()
        {
            this.ChangeTracker.Entries();
            var added = this.ChangeTracker.Entries();
            var modifiedEntities = ChangeTracker.Entries()

            .Where(x => x.State == EntityState.Added ||
            x.State == EntityState.Modified ||
            x.State == EntityState.Deleted).ToList();

            DateTime date = DateTime.Now;

            foreach (var item in modifiedEntities)
            {

                IBaseEntity entity = item.Entity as IBaseEntity;

                if(item != null)
                {
                    switch(item.State)
                    {
                        case EntityState.Added:

                            entity.CreatedDate = date;
                            entity.Status = HC_DOMAIN.Enums.Status.Active;
                            break;

                        case EntityState.Modified:

                            if (entity.Status == HC_DOMAIN.Enums.Status.Deleted)
                            {
                                entity.DeletedDate = date;
                                entity.Status = HC_DOMAIN.Enums.Status.Deleted;
                            }
                            else
                            {
                                entity.UpdatedDate = date;
                                entity.Status = HC_DOMAIN.Enums.Status.Updated;
                            }
                            break;
                    }
                }
            }
                    
            return base.SaveChanges();
        }
    }
}
