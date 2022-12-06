﻿using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Entities.Concrete
{
    public class AppUserRole: IdentityRole, IBaseEntity
    {
        public AppUserRole()
        {
            Status = Status.Active;
        }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatorUserName { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdaterUserName { get; set; }

        public DateTime? DeletedDate { get; set; }
        public string DeleterUserName { get; set; }
    }
}
