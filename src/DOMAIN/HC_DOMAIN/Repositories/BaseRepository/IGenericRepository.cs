using HC_DOMAIN.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Repositories.BaseRepository
{
    public interface IGenericRepository<TEntity> where TEntity : IBaseEntity
    {

        //Add method
        Task<string> Add(TEntity entity);

        //Update method
        Task<string> Update(TEntity entity);

        //Delete method
        Task<string> Delete(Guid id);


        Task<List<TEntity>> GetList(); //Liste getirir.
        Task<TEntity> GetById(Guid id); //ID getirir.

        Task<List<TEntity>> GetByDefaults(Expression<Func<TEntity, bool>> defaultsExpression);

        Task<bool> Any(Expression<Func<TEntity, bool>> defaultExpression);
        
        
    }
}
