using Confluent.Kafka;
using System;
namespace AMV_Travel___Hotel.Config
{
    public static class KafkaConfig
    {
        public static ConsumerConfig GetConsumerConfig()
        {
            return new ConsumerConfig
            {
                GroupId = "1",
                BootstrapServers = "localhost:29092",
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = true
            };
        }

        public static string GetTopic()
        {
            return "amv_travel";
        }
    }
}
