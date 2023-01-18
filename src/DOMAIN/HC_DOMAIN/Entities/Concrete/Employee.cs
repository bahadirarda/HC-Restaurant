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
    public class Employee: BaseEntity, IBaseEntity
    {
        public Employee() 
        {
            Status = Status.Active;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }


        //Relations
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
