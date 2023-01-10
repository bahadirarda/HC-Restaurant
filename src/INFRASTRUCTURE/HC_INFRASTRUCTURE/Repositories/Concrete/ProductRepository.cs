using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(HC_DbContext db): base(db)
        {

        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await GetList();
        }

        public async Task<List<Product>> GetProductsByName(string name)
        {
            return await GetByDefaults(p => p.ProductName == name);
        }

        public async Task<string> CreateProduct(Product product)
        {
            return await Add(product);
        }

        public async Task<string> UpdateProduct(Product product)
        {
            return await Update(product);
        }

        public async Task<string> DeleteProduct(Guid id)
        {
            return await Delete(id);
        }
    }
}
