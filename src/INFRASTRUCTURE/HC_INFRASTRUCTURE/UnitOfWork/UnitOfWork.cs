using System;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_DOMAIN.UnitOfWork;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Concrete;

namespace HC_INFRASTRUCTURE.UnitOfWork
{
	public class UnitOfWork: IUnitOfWork
	{
        private readonly HC_DbContext _db;

        public UnitOfWork(HC_DbContext db)
        {
            _db = db;
        }

        public async Task AllSave()
        {
            await _db.SaveChangesAsync();
        }

        private IAppUserRepository _appUserRepository;
        public IAppUserRepository AppUserRepository
        {
            get
            {
                if (_appUserRepository == null)
                {
                    _appUserRepository = new AppUserRepository(_db);
                }
                return _appUserRepository;
            }
        }

        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if(_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_db);
                }
                return _categoryRepository;
            }
        }

        private ISubCategoryRepository _subCategoryRepository;
        public ISubCategoryRepository SubCategoryRepository
        {
            get
            {
                if (_subCategoryRepository == null)
                {
                    _subCategoryRepository = new SubCategoryRepository(_db);
                }
                return _subCategoryRepository;
            }
        }
        private IEmployeeRepository _employeeRepository;
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_db);

                }
                return _employeeRepository;
            }
        }
        private IDepartmentRepository _departmentRepository;
        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(_db);
                }
                return _departmentRepository;
            }
        }

        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_db);
                }
                return _productRepository;
            }
        }

        private IOrderRepository _orderRepository;
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_db);
                }
                return _orderRepository;
            }
        }

        private IOrderDetailRepository _orderDetailRepository;
        public IOrderDetailRepository OrderDetailRepository
        {
            get
            {
                if (_orderDetailRepository == null)
                {
                    _orderDetailRepository = new OrderDetailRepository(_db);
                }
                return _orderDetailRepository;
            }
        }

        private IRoleRepository _roleRepository;
        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new AppUserRoleRepository(_db);
                }
                return _roleRepository;
            }
        }
    }
}

