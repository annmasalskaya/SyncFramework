using DAL.Entites;
using DAL.Interfaces.Repositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL.Repositories
{
    class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context)
            : base(context)
        {

        }

      
    }
}
