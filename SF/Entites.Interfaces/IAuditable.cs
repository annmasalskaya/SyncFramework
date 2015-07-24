using System;

namespace SF.Entites
{
    interface IAuditable
    {
       DateTime CreateTimestamp { get; set; }

       DateTime UpdateTimestamp { get; set; }
    }
}
