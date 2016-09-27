using CubeSummation.Business.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummation
{
    class Program
    {

        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var test = kernel.Get<ITest>();
            Console.Write(test.HelloWorldText);
            Console.ReadLine();
        }
    }
}
