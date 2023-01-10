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
    public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(HC_DbContext db): base(db)
        {

        }

        public async Task<Category> GetCategoryById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await GetList();
        }

        public async Task<string> CreateCategory(Category category)
        {
            return await Add(category);
        }

        public async Task<string> UpdateCategory(Category category)
        {
            return await Update(category);
        }

        public async Task<string> DeleteCategory(Guid id)
        {
            return await Delete(id);
        }
    }
}
