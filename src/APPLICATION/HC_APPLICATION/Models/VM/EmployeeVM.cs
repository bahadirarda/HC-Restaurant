using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.VM
{
    public class EmployeeVM
    {
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public Status Status { get; set; }
    }
}
