using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface IDepartmentService
    {
        //Add
        Task<string> Create(CreateDepartmentDTO model);
        //Delete
        Task<string> Delete(Guid id);
        //Update
        Task<string> Update(UpdateDepartmentDTO model);
        //List
        Task<List<DepartmentVM>> GetListDepartments();

        Task<List<DepartmentVM>> GetListDefaultDepartments();
        //Find
        Task<UpdateDepartmentDTO> GetById(Guid id);
    }
}
