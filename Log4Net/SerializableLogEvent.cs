using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    internal class SerializableLogEvent
    {
        private LoggingEvent loggingEvent;
        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            this.loggingEvent = loggingEvent;
        }
        public DateTime DateTime => loggingEvent.TimeStamp;
        public string UserName => loggingEvent.UserName;
        public object MessageObject => loggingEvent.MessageObject;
    }
}
