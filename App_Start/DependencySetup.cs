using CubeSummation.Business;
using CubeSummation.Business.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummation.App_Start
{
    public class DependencySetup : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ITest>().To<Test>();
        }
    }
}
