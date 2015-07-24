using System;
using System.Collections.Generic;
using SF.Entites;

namespace DAL.Entites
{
    public class Comment : SFEntity
    {
        public string Body { get; set; }

        public virtual User User { get; set; }

        public virtual Article Article { get; set; }
    }
}
