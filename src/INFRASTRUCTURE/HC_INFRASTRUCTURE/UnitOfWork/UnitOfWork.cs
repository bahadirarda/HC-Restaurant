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

    }
}

