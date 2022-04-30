using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetAspect
{
    [Serializable]
    internal class SerializableLogEvent
    {
        private LoggingEvent _loggingEvent;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }

        public DateTime DateTime => _loggingEvent.TimeStamp;
        public string Username => _loggingEvent.UserName;
        public object MessageObject => _loggingEvent.MessageObject;
    }
}
