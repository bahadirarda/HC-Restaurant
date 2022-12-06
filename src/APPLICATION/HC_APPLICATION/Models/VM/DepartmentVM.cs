using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.VM
{
    public class DepartmentVM
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }

        public Status Status { get; set; }

    }
}
