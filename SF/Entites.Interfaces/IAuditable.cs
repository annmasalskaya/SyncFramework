using System;

namespace SF.Entites.Interfaces
{
    interface IAuditable
    {
       DateTime CreatedTimestamp { get; set; }

       DateTime UpdatedTimestamp { get; set; }
    }
}
