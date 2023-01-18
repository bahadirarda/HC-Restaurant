using HC_DOMAIN.Entities.BaseClass;
using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Concrete
{
    public class SubCategory: BaseEntity, IBaseEntity
    {
        public SubCategory()
        {
            Status = Status.Active;
        }
        
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
     

        //Relations
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
