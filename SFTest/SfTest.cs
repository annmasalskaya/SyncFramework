using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Entites;
using DAL;
using DAL.UnitOfWork;
using System.Collections.ObjectModel;
using System.Data.Entity;


namespace SFTest
{
    class SFTest
    {
        static void Main(string[] args)
        {
            var dbContext = new ApplicationDbContext();
      
            using (var uow = new UnitOfWork(dbContext))
            {
                // Creating user
                // var user1 = new User { Login = "Anna", Password = "123" };

                // var userRepo = new UserRepository(dbContext);
                //userRepo.Create(user1);
                //uow.Commit();
                var userRepo = new UserRepository(dbContext);

                var user1 = new User { Login = "Anna1", Password = "123" };
                var user2 = new User { Login = "Anna2", Password = "123" };

                userRepo.Create(user1);
                userRepo.Create(user2);
                uow.Commit();

                var users = userRepo.GetAll();

                Console.WriteLine("All users count: " + users.Count());

                var anna = userRepo.GetBy(user1.Login);
                userRepo.Delete(anna);
                uow.Commit();

                users = userRepo.GetAll();

                Console.WriteLine("All filtered users count: " + users.Count());
                Console.ReadLine();

                // Creating user article
                // var article1 = new Article { Title = "Article1", Body = "Article1 BodyText" };

                //  var anna = userRepo.GetBy(user1.Login);


                // userRepo.Delete(anna);
                //anna.Articles.Add(article1);
                //uow.Commit();


                // var comment1 = new Comment { Body = "Article1 is my first arctile. (Anna)" };
                /*                var articleRepo = new ArticleRepository(dbContext);
                anna.Comments.Add(comment1);
                article1.Comments.Add(comment1);
                uow.Commit();
                */

            }
        }
    }
}
