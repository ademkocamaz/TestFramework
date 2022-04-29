using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingAOPTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic testClass = new TestClass();
            testClass.TestMethod();
            Console.ReadKey();
        }
    }
}
