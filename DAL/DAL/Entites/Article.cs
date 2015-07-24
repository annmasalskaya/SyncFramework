using System;
using System.Collections.Generic;
using System.Linq;
using SF.Entites;
using SF;

namespace DAL.Entites
{
    public class Article : SFEntity
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Body { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public override void OnDeleting(SFDbContext context)
        {
            foreach (var comment in context.Set<Comment>().ToList())
            {
                context.Set<Comment>().Remove(comment);
            }
        }
    }
}
