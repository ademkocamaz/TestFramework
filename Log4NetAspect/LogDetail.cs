using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetAspect
{
    internal class LogDetail
    {
        public string FullName { get; set; }
        public string MethodName { get; set; }
        public List<LogParameter> Paramaters { get; set; }
    }
}
