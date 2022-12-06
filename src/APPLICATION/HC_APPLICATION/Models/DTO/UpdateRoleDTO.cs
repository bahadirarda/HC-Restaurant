﻿using HC_DOMAIN.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.DTO
{
    public class UpdateRoleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
