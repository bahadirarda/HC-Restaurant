using System;
using HC_DOMAIN.Repositories.EntityRepository;

namespace HC_DOMAIN.UnitOfWork
{
	public interface IUnitOfWork
	{
        IAppUserRepository AppUserRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IProductRepository ProductRepository { get; }
        IRoleRepository RoleRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        Task AllSave();
    }
}

