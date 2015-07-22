using System;
using SF.Entites;

namespace SF.Entites
{
    public abstract class SoftDeleteEntity : ISoftDeleteEntity  
    {
        public DateTime DeleteTimestap { get; set; }

        public virtual void onDelete() {}
    }
}
