using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Concrete
{
    public class Order: IBaseEntity
    {
        public Order()
        {
            Status = Status.Active;
        }
        public Guid ID { get; set; }

        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdaterUserName { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeleterUserName { get; set; }

        //Relations
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
