using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface IEmployeeService
    {
        //Add
        Task<string> Create(CreateEmployeeDTO model);
        //Delete
        Task<string> Delete(Guid id);
        //Update
        Task<string> Update(UpdateEmployeeDTO model);
        
        Task<List<EmployeeVM>> GetListEmployees();
        Task<List<EmployeeVM>> GetListDefaultEmployees();
        //Find
        Task<UpdateEmployeeDTO> GetById(Guid id);
    }
}
