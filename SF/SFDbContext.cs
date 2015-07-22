using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SF.Entites;

namespace SF.SFDbContext
{

    public class SFDbContext : DbContext
    {
        public SFDbContext()
            : base()
        {

        }

        public SFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditEntity
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditEntity entity = entry.Entity as IAuditEntity;
                if (entity != null)
                {
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedTimestap = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedTimestap).IsModified = false;
                    }

                    entity.UpdateTimestap = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
