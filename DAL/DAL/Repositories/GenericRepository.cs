using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using DAL.Interfaces.Repositories;
using SF.Entites;
using EntityFramework.DynamicFilters;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext _dbContext;
        readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable<TEntity>();
        }

        public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> query = _dbSet.Where(predicate).AsEnumerable();
            return query;
        }

        public IEnumerable<TEntity> GetByWithoutFilters(Expression<Func<TEntity, bool>> predicate)
        {
            _dbContext.DisableAllFilters();
            
            IEnumerable<TEntity> result = _dbSet.Where(predicate).ToList<TEntity>();
           
            _dbContext.EnableAllFilters();
            
            return result;
        }


        public TEntity Create(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            return _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
