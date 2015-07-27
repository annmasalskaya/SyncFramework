using System.Collections.Generic;
using System.Linq;
using SF.Entites;
using SF;


namespace DAL.Entites
{
    public class User : SFEntity
    {
        public User()
        {
            Articles = new HashSet<Article>();
            Comments = new HashSet<Comment>();
        }

        public string Login { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public override void OnDeleting(SFDbContext context){
            foreach (var article in this.Articles.ToList())
            {
                context.Set<Article>().Remove(article);
            }

            foreach (var comment in this.Comments.ToList())
            {
                context.Set<Comment>().Remove(comment);
            }
        }
    }
}
