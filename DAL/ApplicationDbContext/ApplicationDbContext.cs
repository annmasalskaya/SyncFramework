using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;

namespace DAL.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<DalUser> Users { get; set; }
        DbSet<DalDevice> Devices { get; set; }

        public ApplicationDbContext () :base("name=ApplicationDbContext")
        {
             
        }
    }
}
