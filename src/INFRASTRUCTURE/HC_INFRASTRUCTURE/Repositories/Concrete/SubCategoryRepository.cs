using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class SubCategoryRepository: GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(HC_DbContext db): base(db)
        {

        }
        public async Task<SubCategory> GetSubCategoryById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            return await GetList();
        }

        public async Task<List<SubCategory>> GetSubCategoriesByCategoryId(Guid categoryId)
        {
            return await GetByDefaults(p => p.CategoryId == categoryId);
        }

        public async Task<string> CreateSubCategory(SubCategory subCategory)
        {
            return await Add(subCategory);
        }

        public async Task<string> UpdateSubCategory(SubCategory subCategory)
        {
            return await Update(subCategory);
        }

        public async Task<string> DeleteSubCategory(Guid id)
        {
            return await Delete(id);
        }
    }
}
