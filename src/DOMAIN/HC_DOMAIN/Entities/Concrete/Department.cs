using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Concrete
{
    public class Department: IBaseEntity
    {
        public Department()
        {
            Status = Status.Active;
        }
        public Guid ID { get; set; }
        public string DepartmentName { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatorUserName { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdaterUserName { get; set; }

        public DateTime? DeletedDate { get; set; }
        public string DeleterUserName { get; set; }

        //relations
        public virtual List<Employee> Employees { get; set; }
    }
}
