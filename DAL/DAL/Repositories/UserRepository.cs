using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Interfaces.Repositories;
using DAL.Entites;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<DalUser>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {

        }

        public DalUser GetBy(string login)
        {
            return GetBy(u => u.Login == login).SingleOrDefault();
        }
    }
}