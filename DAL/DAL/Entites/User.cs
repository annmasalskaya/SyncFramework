using System.Collections.Generic;
using SF.Entites;

namespace DAL.Entites
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public virtual IEnumerable<Article> Articles { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }   
    }
}
