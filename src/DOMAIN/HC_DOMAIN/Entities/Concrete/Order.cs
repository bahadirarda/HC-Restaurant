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
    public class Order: BaseEntity, IBaseEntity
    {
        public Order()
        {
            Status = Status.Active;
        }
        



        //Relations
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
