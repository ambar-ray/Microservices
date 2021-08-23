using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.interfaces
{
    /// <summary>
    /// Mechanism to create messaging event
    /// </summary>
    public interface IMessagingEvent
    {
        string Id { get; set; }
        string ClientId { get; set; }
        string CorrelationId { get; set; }
        string Source { get; set; }
        string Destination { get; set; }
        string Version { get; set; }
        DateTime EventDate { get; set; }
        string Sender { get; set; }
        string Receiver { get; set; }
        string MessageType { get; set; }
    }
}
