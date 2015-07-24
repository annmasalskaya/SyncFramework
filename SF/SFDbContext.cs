using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SF.Entites;
using System.Data.Entity.Infrastructure;

namespace SF
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
                .Where(x => x.Entity is IAuditable
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));
            UpdateEntites(modifiedEntries);
        
            return base.SaveChanges();
        }

        private void UpdateEntites(IEnumerable<DbEntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                IAuditable entity = entry.Entity as IAuditable;
                if (entity != null)
                {
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreateTimestamp = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreateTimestamp).IsModified = false;
                    }

                    entity.UpdateTimestamp = now;
                }

            }
        }

        private void SoftDelete(IEnumerable<DbEntityEntry> entries)
        {     
            foreach (var entry in entries)
            {
                ISoftDeletable entity = entry.Entity as ISoftDeletable;
                if (entity != null)
                {
                    entry.State = EntityState.Modified;
                    DateTime now = DateTime.UtcNow;
                    entity.isDeleted = true;
                    entity.DeletedTimestamp = now;
                }
                entity.OnDeleting(this);
            }

            var cascadeDeletedEntries = ChangeTracker.Entries().Where(p => p.State == EntityState.Deleted);
            if (cascadeDeletedEntries.Count() > 0)
                SoftDelete(cascadeDeletedEntries);
        }
    }
}
