using HC_DOMAIN.Entities.Interface;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Repositories.EntityRepository
{
    public interface IGenericRepository<TEntity> where TEntity : IBaseEntity
    {

        //Add method
        Task<string> Add(TEntity entity);

        //Update method
        Task<string> Update(TEntity entity);

        //Delete method
        Task<string> Delete(Guid id);


        Task<List<TEntity>> GetList(); 
        Task<TEntity> GetById(Guid id); //Guid tipinde id getirir.


        Task<List<TEntity>> GetByDefaults(Expression<Func<TEntity, bool>> defaultsExpression);
        Task<bool> Any(Expression<Func<TEntity, bool>> defaultExpression);

        
        // Filtrelenmiş ilk sonucu getir
        Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> selector,
                                                         Expression<Func<TEntity, bool>> expression,
                                                         Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                         Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        //Listelenmiş filtreleyerek getir.
        Task<List<TResult>> GetListFilteredFirstOrDefaults<TResult>(Expression<Func<TEntity, TResult>> selector,
                                                         Expression<Func<TEntity, bool>> expression,
                                                         Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                         Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        #region Standart Functions

        //TEntity Get(Expression<Func<TEntity, bool>> expression);
        //IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        //IEnumerable<TEntity> GetAll();
        //void Add(TEntity entity);
        //void AddRange(IEnumerable<TEntity> entities);
        //void Remove(TEntity entity);
        //void RemoveRange(IEnumerable<TEntity> entities);
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);
        //Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        //Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        //Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        //Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        //Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        #endregion


    }
}
