using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Entites
{
    interface IVersionable
    {
        int Version { get; set; }
    }
}
