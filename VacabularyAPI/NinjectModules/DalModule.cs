using DAL;
using Ninject.Modules;
using Ninject.Web.Common;
using System.Data.Entity;
using DAL.Contracts.Repositories;
using DAL.Repositories;

namespace NinjectModules
{
    public class DalModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<DatabaseContext>().InRequestScope();
            Bind<RepositoryContext>().ToSelf().InRequestScope();

            Bind<IWordRepository>().To<WordRepository>().InRequestScope();
        }
    }
}
