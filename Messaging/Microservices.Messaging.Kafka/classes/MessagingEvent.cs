using Microservices.Messaging.Kafka.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.classes
{
    public abstract class MessagingEvent : IMessagingEvent
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string CorrelationId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Version { get; set; }
        public DateTime EventDate { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string MessageType { get; set; }
    }
}
