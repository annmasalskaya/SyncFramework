using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF.Entites.Interfaces;
using SF.Entites;

namespace BLL.Interfaces.Services
{
    public interface IVersionControlService<TEntity> where TEntity : SFEntity
    {
        IEnumerable<TEntity> GetUpdatedAfter(DateTime timestamp);
        IEnumerable<TEntity> GetDeletedAfter(DateTime timestamp);
        IEnumerable<TEntity> ApplyChanges(IEnumerable<TEntity> entites);     
    }
}
