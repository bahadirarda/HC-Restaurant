using AutoMapper;
using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class AppUserRepository: GenericRepository<AppUser>, IAppUserRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;

        public AppUserRepository(HC_DbContext db, UserManager<IdentityUser> userManager) : base(db)
        {
            _userManager = userManager;
        }

        public AppUserRepository(HC_DbContext db) : base(db)
        {
        }

        public async Task<AppUser> GetUserById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<AppUser> GetUserByUserName(string userName)
        {
            var identityUser = await _userManager.FindByNameAsync(userName);
            var appUser = _mapper.Map<IdentityUser, AppUser>(identityUser);
            return appUser;
        }

        public async Task<List<AppUser>> GetAllUsers()
        {
            return await GetList();
        }

        public async Task<string> CreateUser(AppUser user)
        {
            return await Add(user);
        }

        public async Task<string> UpdateUser(AppUser user)
        {
            return await Update(user);
        }

        public async Task<string> DeleteUser(Guid id)
        {
            return await Delete(id);
        }
    }
}
