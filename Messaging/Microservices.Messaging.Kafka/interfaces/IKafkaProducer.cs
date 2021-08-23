using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.interfaces
{
    /// <summary>
    /// Provides mechanism to create Kafka Producer
    /// </summary>
    /// <typeparam name="TKey">Indicates message's key in Kafka topic</typeparam>
    /// <typeparam name="TValue">Indicates message's value in Kafka topic</typeparam>
    public interface IKafkaProducer<in TKey, in TValue> where TValue : class
    {
        /// <summary>
        ///  Triggered when the service is ready to produce the Kafka topic.
        /// </summary>
        /// <param name="topic">Indicates topic name</param>
        /// <param name="key">Indicates message's key in Kafka topic</param>
        /// <param name="value">Indicates message's value in Kafka topic</param>
        /// <returns></returns>
        Task ProduceAsync(string topic, TKey key, TValue value);
    }
}
