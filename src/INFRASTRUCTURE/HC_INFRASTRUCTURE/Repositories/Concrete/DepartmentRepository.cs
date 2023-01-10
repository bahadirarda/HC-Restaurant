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
    public class DepartmentRepository: GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HC_DbContext db): base(db)
        {
        
        }

        public async Task<Department> GetDepartmentById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            return await GetList();
        }

        public async Task<string> CreateDepartment(Department department)
        {
            return await Add(department);
        }

        public async Task<string> UpdateDepartment(Department department)
        {
            return await Update(department);
        }

        public async Task<string> DeleteDepartment(Guid id)
        {
            return await Delete(id);
        }
    }
}
