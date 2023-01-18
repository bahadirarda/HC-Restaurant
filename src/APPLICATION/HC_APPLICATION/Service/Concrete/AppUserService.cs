using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using HC_APPLICATION.Service.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Concrete
{
    public class AppUserService : IAppUserService
    {
        public AppUserService()
        {
        }

        public Task<UpdateUserDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserVM> GetByUser(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> Login(LoginDTO model)
        {
            throw new NotImplementedException();
        }

        public Task LogOut()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> Register(RegisterDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUser(UpdateUserDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
