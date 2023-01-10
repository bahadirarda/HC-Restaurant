using HC_DOMAIN.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Repositories.EntityRepository
{
    public interface ISubCategoryRepository: IGenericRepository<SubCategory>
    {
        Task<SubCategory> GetSubCategoryById(Guid id);
        Task<List<SubCategory>> GetAllSubCategories();
        Task<List<SubCategory>> GetSubCategoriesByCategoryId(Guid categoryId);
    }
}
