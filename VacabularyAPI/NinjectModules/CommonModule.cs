using Common.Contracts.Logging;
using Common.Logging;
using Ninject.Modules;

namespace NinjectModules
{
    public class CommonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>().InSingletonScope();
        }
    }
}
