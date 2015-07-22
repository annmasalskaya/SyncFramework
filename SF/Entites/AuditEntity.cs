using System;

namespace SF.Entites
{
    public abstract class AuditEntity : BaseEntity, IAuditEntity
    {
        public DateTime CreateTimestap { get; set; }

        public DateTime UpdateTimestap { get; set; }
    }
}
