using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HC_DbContext db): base(db) 
        {

        }
        public async Task<Employee> GetEmployeeById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<Employee>> GetEmployeesByDepartmentId(Guid departmentId)
        {
            return await GetByDefaults(p => p.DepartmentId == departmentId);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await GetList();
        }

        public async Task<string> CreateEmployee(Employee employee)
        {
            return await Add(employee);
        }

        public async Task<string> UpdateEmployee(Employee employee)
        {
            return await Update(employee);
        }

        public async Task<string> DeleteEmployee(Guid id)
        {
            return await Delete(id);
        }
    }
}
