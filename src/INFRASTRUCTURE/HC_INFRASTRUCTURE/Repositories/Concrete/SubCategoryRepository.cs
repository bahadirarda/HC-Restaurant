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
    }
}
