using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetAspect
{
    internal class Program
    {
        //private static ILog log = LogManager.GetLogger("Logger");
        static void Main(string[] args)
        {
            //log.Info("Merhaba");
            TestClass testClass = new TestClass();
            testClass.TestMethod();
            testClass.Test2Method();

            Console.ReadKey();

        }
    }
}
