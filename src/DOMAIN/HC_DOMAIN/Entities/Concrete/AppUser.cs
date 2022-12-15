using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using Microsoft.AspNetCore.Identity;

namespace HC_DOMAIN.Entities.Concrete
{
    public class AppUser: IdentityUser, IBaseEntity
    {
        public AppUser()
        {
            Status = Status.Active;
        }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }

        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }

        //Relations
        public virtual List<Order> Orders { get; set; }
    }
}
