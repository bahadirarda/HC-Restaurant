using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task<SignInResult> Login(LoginDTO model);
        Task LogOut();
        Task<string> UpdateUser(UpdateUserDTO model);
        Task<UpdateUserDTO> GetById(string id);
        Task<AppUserVM> GetByUser(string userName);

    }
}
