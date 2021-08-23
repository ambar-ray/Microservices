using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microservices.Messaging.Kafka.constants;
using Microservices.Messaging.Kafka.interfaces;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace Microservices.Messaging.Kafka.services
{
    public class ConsumerService<TKey, TValue> : BackgroundService where TValue : class, new()
    {
        private readonly IKafkaConsumer<TKey, TValue> _consumer;
        public ConsumerService(IKafkaConsumer<TKey, TValue> consumer) => _consumer = consumer;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                await _consumer.Consume(AppConstants.Topic0, stoppingToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{(int)HttpStatusCode.InternalServerError} ConsumeFailedOnTopic - {AppConstants.Topic0}, {ex}");
            }
        }
        public override void Dispose()
        {
            _consumer.Close();
            _consumer.Dispose();
            base.Dispose();
        }
    }
}
