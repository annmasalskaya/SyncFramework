using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SF.Entites;
using System.Data.Entity.Infrastructure;
using SF;

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
            var deletedEntries = ChangeTracker.Entries().Where(p => p.State == EntityState.Deleted);
            SoftDelete(deletedEntries);

            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditEntity
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));

            UpdateEntites(modifiedEntries);


            return base.SaveChanges();
        }

        private void UpdateEntites(IEnumerable<DbEntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                IAuditEntity entity = entry.Entity as IAuditEntity;
                if (entity != null)
                {
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreateTimestap = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreateTimestap).IsModified = false;
                    }

                    entity.UpdateTimestap = now;
                }
            }
        }

        private void SoftDelete(IEnumerable<DbEntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                ISoftDeleteEntity entity = entry.Entity as ISoftDeleteEntity;
                if (entity != null)
                {
                    DateTime now = DateTime.UtcNow;
                    entity.DeleteTimestap = now;
                    entry.State = EntityState.Modified;
                }
            }
        }
    }
}
