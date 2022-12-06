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
    public class Category: BaseEntity, IBaseEntity
    {
        public Category()
        {
            Status = Status.Active;
        }
        public Guid ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        


        //Relations
        public virtual List<SubCategory> SubCategories { get; set; }

    }
}
