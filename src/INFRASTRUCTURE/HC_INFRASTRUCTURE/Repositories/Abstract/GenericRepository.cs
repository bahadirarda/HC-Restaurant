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
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

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

        public virtual async Task<string> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
            return "Success";
        }

        public virtual async Task<string> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return "Success";
        }

        public virtual async Task<string> Delete(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
            return "Success";
        }

        public virtual async Task<List<TEntity>> GetList()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetByDefaults(Expression<Func<TEntity, bool>> defaultsExpression)
        {
            return await _dbSet.Where(defaultsExpression).ToListAsync();
        }

        public virtual async Task<bool> Any(Expression<Func<TEntity, bool>> defaultsExpression)
        {
            return await _dbSet.AnyAsync(defaultsExpression);
        }

        public virtual async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> selector,
                                                                 Expression<Func<TEntity, bool>> expression,
                                                                 Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                                 Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
            {
                query = include(query);
            }
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(selector).FirstOrDefaultAsync();
            }
            return await query.Select(selector).FirstOrDefaultAsync();
        }

        public virtual async Task<List<TResult>> GetListFilteredFirstOrDefaults<TResult>(Expression<Func<TEntity, TResult>> selector,
                                                             Expression<Func<TEntity, bool>> expression,
                                                             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                             Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
            {
                query = include(query);
            }
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(selector).ToListAsync();
            }
            return await query.Select(selector).ToListAsync();
        }
    }
}
