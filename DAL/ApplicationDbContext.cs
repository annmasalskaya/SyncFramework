using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;
using SF;


namespace DAL
{
    public class ApplicationDbContext : SFDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {

        }
    }
}
