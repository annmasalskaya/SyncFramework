using System;

namespace SF.Entites {

    interface ISoftDeleteEntity 
    {
        DateTime DeleteTimestap { get; set; }
    }
}
