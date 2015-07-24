using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    public abstract class SFEntity : BaseEntity, IAuditable, ISoftDeletable, IVersionable
    {
        public DateTime CreateTimestamp { get; set; }

        public DateTime UpdateTimestamp { get;  set; }

        public bool isDeleted { get; set; }

        public DateTime? DeletedTimestamp { get;  set; }

        public int Version { get; set; }

        public virtual void OnDeleting(SFDbContext context) { }
    }
}
