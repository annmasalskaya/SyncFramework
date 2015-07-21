using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using SF.Entites;

namespace DAL.Entites
{
    class Comment : AuditableEntity
    {
        public int UserId { get; set; }

        public int ArticleId { get; set;}

        [ForeignKey("UserId")]
        public virtual User Author { get; set; }
    }
}
