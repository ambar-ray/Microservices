using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.constants
{
    public static class AppConstants
    {
        public static string Topic0 => "Topic0";
        public static int NumMessagesToWaitBeforeStoringOffset => 100;
    }
}
