﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Interfaces.Repositories;
using DAL.Entites;
using SF;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SFDbContext context)
            : base(context)
        {

        }

        public User GetBy(string login)
        {
            return GetBy(u => u.Login == login).SingleOrDefault();
        }
    }
}