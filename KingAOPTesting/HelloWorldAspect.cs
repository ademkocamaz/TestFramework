﻿using KingAOP.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingAOPTesting
{
    public class HelloWorldAspect:OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("OnEntry: Hello KingAOP");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("OnExit: Hello KingAOP");
        }
    }
}
