using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
    interface ISoftDeleteEntity
    {
        DateTime DeleteDate { get; set; }
    }
}
