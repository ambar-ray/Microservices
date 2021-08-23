using Microservices.Messaging.Kafka.classes;
using Microservices.Messaging.Kafka.constants;
using Microservices.Messaging.Kafka.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProducerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly IKafkaProducer<string, GenericMessage> _kafkaProducer;
        public ProducerController(IKafkaProducer<string, GenericMessage> kafkaProducer) => _kafkaProducer = kafkaProducer;

        [HttpPost]
        [Route("Message")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [SwaggerOperation("Produce message", "This endpoint can be used to produce message in Kafka Topic")]
        public async Task<IActionResult> ProduceMessage(GenericMessage request)
        {
            await _kafkaProducer.ProduceAsync(AppConstants.Topic0, null, request);
            return Ok("Message is being processed");
        }
    }
}
