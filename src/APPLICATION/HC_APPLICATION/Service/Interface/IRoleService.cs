using HC_APPLICATION.Models.DTO;
using HC_DOMAIN.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface IRoleService
    {
        //Add
        Task<string> Create(CreateRoleDTO model);
        //Update
        Task<string> Update(UpdateRoleDTO model);
        //Delete
        Task<string> Delete(string id);
        //Find
        Task<UpdateRoleDTO> GetById(string id);
        //Any
        Task<bool> IsRoleExist(string roleName);
        //List
        IQueryable<AppUserRole> GetRolesList();
    }
}
