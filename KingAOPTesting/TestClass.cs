using KingAOP;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KingAOPTesting
{
    public class TestClass : IDynamicMetaObjectProvider
    {
        [HelloWorldAspect]
        public void TestMethod()
        {
            Console.WriteLine("TestMethod()");
        }
        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new AspectWeaver(parameter, this);
        }
    }
}
