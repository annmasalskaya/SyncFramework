using System;
using System.Collections.Generic;
using System.Data.Entity;
using Ninject.Modules;
using Ninject.Web.Common;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;
using DAL.Repositories;
using DAL.UnitOfWork;
using DAL;
using DAL.Entites;
using SF;
using BLL.Interfaces.Services;
using BLL.Services;

namespace DependencyResolver
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository<User>>().To<UserRepository>().InRequestScope();

            Bind<IVersionControlService<User>>().To<VersionControlService<User>>().InRequestScope();

            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
         
            Bind<SFDbContext>().To<ApplicationDbContext>().InRequestScope();      
        }
    }
}
