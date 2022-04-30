using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetAspect
{
    [LogAspect(typeof(FileLogger))]
    internal class TestClass
    {
        public void TestMethod()
        {
            Console.WriteLine("TestMethod()");

        }

        public void Test2Method()
        {
            Console.WriteLine("Test2Method()");
        }
    }
}
