using HC_DOMAIN.Entities.Interface;
using HC_DOMAIN.Repositories.BaseRepository;
using HC_INFRASTRUCTURE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Abstract
{
    public class BaseRepository<T>: IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly HC_DbContext _db;
        protected DbSet<T> _table;

        public BaseRepository(HC_DbContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public async Task<string> Add(T entity)
        {
            await _table.AddAsync(entity);
            _db.SaveChanges();
            return "Data added";
        }
        
        public async Task<string> Update(T entity)
        {
            try
            {
                _db.Entry<T>(entity).State = EntityState.Modified;
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
                T deleted = await GetById(id);
                deleted.Status = HC_DOMAIN.Enums.Status.Deleted;
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
