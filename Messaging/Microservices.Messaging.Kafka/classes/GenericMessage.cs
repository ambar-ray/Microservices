using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.classes
{
    public class GenericMessage : MessagingEvent
    {
        public string ObjectJson { get; set; }
    }
}
