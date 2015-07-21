using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;
using SF.SFDbContext;

namespace DAL.ApplicationDbContext
{
    public class ApplicationDbContext : SFDbContext 
    {
        DbSet<User> Users { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext () :base("name=ApplicationDbContext")
        {
             
        }
    }
}
