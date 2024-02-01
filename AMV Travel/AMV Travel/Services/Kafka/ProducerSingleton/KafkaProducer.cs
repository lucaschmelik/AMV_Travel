using AMV_Travel.Services.Kafka.Interface;
using Confluent.Kafka;

namespace AMV_Travel.Services.Kafka.ProducerSingleton
{
    public class KafkaProducer : IKafkaProducer
    {
        private readonly ProducerConfig _producerConfig;

        public KafkaProducer()
        {
            _producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:29092",
            };
        }

        public async Task<DeliveryResult<Null, string>> ProduceAsync(string topic, string message)
        {
            using (var producer = new ProducerBuilder<Null, string>(_producerConfig).Build())
            {
                return await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
            }
        }
    }
}
