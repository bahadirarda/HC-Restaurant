using HC_DOMAIN.Entities.Interface;

using HC_INFRASTRUCTURE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC_DOMAIN.Enums;
using HC_DOMAIN.Repositories.EntityRepository;

namespace HC_INFRASTRUCTURE.Repositories.Abstract
{
    public abstract class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly HC_DbContext _db;
        protected DbSet<TEntity> _dbSet;

        public GenericRepository(HC_DbContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public async Task<string> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            _db.SaveChanges();
            return "Data added";
        }
        
        public async Task<string> Update(TEntity entity)
        {
            try
            {
                _db.Entry<TEntity>(entity).State = EntityState.Modified;
                _db.SaveChanges();

                return "Data updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                TEntity deleted = await GetById(id);
                deleted.Status = Status.Deleted;
                Update(deleted);
                return "Data deleted";
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
