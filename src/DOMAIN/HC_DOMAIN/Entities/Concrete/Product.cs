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
    public class Product: BaseEntity, IBaseEntity
    {
        public Product()
        {
            Status = Status.Active;
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string ImagePath { get; set; }

    

        //Relations
        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
