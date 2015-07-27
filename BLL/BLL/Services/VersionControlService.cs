using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF.Entites.Interfaces;
using DAL.Repositories;
using DAL.Interfaces.Repositories;
using DAL;
using SF.Entites;
using BLL.Interfaces.Services;

namespace BLL.Services
{
    public class VersionControlService<TEntity> : IVersionControlService<TEntity>  where TEntity : SFEntity
    {
        IGenericRepository<TEntity> _repository;
       
        public VersionControlService (IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TEntity> GetUpdatedAfter(DateTime timestamp)
        {
            return _repository.GetBy(x => x.UpdatedTimestamp >= timestamp);
        }

        public IEnumerable<TEntity> GetDeletedAfter(DateTime timestamp)
        {
            return _repository.GetByWithoutFilters(x => x.DeletedTimestamp >= timestamp);
        }

        public IEnumerable<TEntity> ApplyChanges(IEnumerable<TEntity> entites)
        {
            throw new NotImplementedException();
        }
    }
}
