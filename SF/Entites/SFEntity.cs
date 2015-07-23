using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    public abstract class SFEntity : BaseEntity, IAuditEntity, ISoftDeleteEntity, IVersionEntity
    {

        public DateTime CreateTimestap
        { get; set; }

        public DateTime UpdateTimestap
        { get; set; }

        public DateTime DeleteTimestap
        { get; set; }

        public void onDelete()
        {
        }

        public int Version
        { get; set; }
    }
}
