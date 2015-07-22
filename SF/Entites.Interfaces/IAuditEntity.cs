using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    interface IAuditEntity
    {
       DateTime CreatedTimestap { get; set; }

       DateTime UpdateTimestap { get; set; }

       DateTime DeleteTimestap { get; set; }
    }
}
