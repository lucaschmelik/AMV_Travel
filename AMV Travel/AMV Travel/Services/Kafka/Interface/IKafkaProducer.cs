using Confluent.Kafka;

namespace AMV_Travel.Services.Kafka.Interface
{
    public interface IKafkaProducer
    {
        Task<DeliveryResult<Null, string>> ProduceAsync(string topic, string message);
    }
}
