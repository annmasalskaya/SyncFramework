using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DependencyResolver;
using BLL.Interfaces.Services;
using DAL.Entites;

namespace BLL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new DependencyResolverModule());
            
            var service = kernel.Get<IVersionControlService<User>>();
            var result = service.GetDeletedAfter(new DateTime(2012, 4, 12));
            Console.WriteLine(result.Count());
            Console.ReadLine();
        }

    }
}
