using CubeSummation.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummation.Business
{
    public class Test : ITest
    {
        public string HelloWorldText
        {
            get
            {
                return "Hello World";
            }
        }
    }
}
