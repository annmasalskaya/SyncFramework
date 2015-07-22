using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    public abstract class AuditEntity : BaseEntity, IAuditEntity
    {
        public DateTime CreatedTimestap { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
