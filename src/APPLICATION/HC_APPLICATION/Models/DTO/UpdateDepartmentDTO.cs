using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.DTO
{
    public class UpdateDepartmentDTO
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatorUserName { get; set; }
        
        public DateTime? UpdatedDate { get; set; }
        public string UpdaterUserName { get; set; }
        
        public DateTime? DeletedDate { get; set; }
        public string DeleterUserName { get; set; }
    }
}
