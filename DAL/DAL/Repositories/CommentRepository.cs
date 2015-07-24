using DAL.DAL.Interfaces.Repositories;
using DAL.Entites;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context)
            : base(context)
        {

        }
    }
}
