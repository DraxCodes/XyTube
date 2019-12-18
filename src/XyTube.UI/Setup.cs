using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
