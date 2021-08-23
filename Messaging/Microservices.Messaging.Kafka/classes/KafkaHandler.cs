using Microservices.Messaging.Kafka.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Messaging.Kafka.classes
{
    public class KafkaHandler<TKey, TValue> : IKafkaHandler<TKey, TValue> where TValue : class, new()
    {
        public async Task HandleAsync(TKey key, TValue value)
        {
            //Do whatever you want with the message key and value
            await Task.CompletedTask;
        }
    }
}
