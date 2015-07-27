using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SF.Entites;

namespace DAL.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetByWithoutFilters(Expression<Func<TEntity, bool>> predicate);


        TEntity Create(TEntity entity);
        TEntity Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
