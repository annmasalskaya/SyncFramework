using System;

namespace SF.Entites
{
    interface IAuditEntity
    {
       DateTime CreateTimestap { get; set; }

       DateTime UpdateTimestap { get; set; }
    }
}
