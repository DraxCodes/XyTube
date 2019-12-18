using Ninject;
using Ninject.Modules;
using XyTube.Core.Services;
using XyTube.UI.UiServices;

namespace XyTube.UI
{
    internal sealed class Setup
    {
        public readonly IKernel Kernel;

        internal Setup()
        {
            Kernel = new StandardKernel(new XyModule());
        }
    }

    internal sealed class XyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>().InSingletonScope();
        }
    }
}
