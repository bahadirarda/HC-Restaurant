using HC_DOMAIN.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Context
{
    public class HC_DbContext: IdentityDbContext<AppUser>
    {
    }
}
