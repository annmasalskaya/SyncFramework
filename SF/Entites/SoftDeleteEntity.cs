using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    public abstract class SoftDeleteEntity
    {
        public DateTime DeleteTimestap { get; set; }

        public virtual void onDelete();
    }
}
