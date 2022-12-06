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
    public class Department: BaseEntity, IBaseEntity
    {
        public Department()
        {
            Status = Status.Active;
        }
        public Guid ID { get; set; }
        public string DepartmentName { get; set; }
      
        //Relations
        public virtual List<Employee> Employees { get; set; }
    }
}
