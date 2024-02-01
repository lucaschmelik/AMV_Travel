using AMV_Travel___Hotel.Config;
using AMV_Travel___Hotel.DataAccess.Context;
using AMV_Travel___Hotel.Presentation;
using AMV_Travel___Hotel.Services;
using Confluent.Kafka;

namespace AMV_Travel___Hotel.Consumer
{
    public class KafkaService
    {        
        private readonly ApplicationDbContext _context;

        public KafkaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void ConsumeMessages()
        {
            var config = KafkaConfig.GetConsumerConfig();

            using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
            {
                consumer.Subscribe(KafkaConfig.GetTopic());
                ConsolePresenter.DisplayListeningMessage();

                while (true)
                {
                    try
                    {
                        var consumeResult = consumer.Consume();

                        ConsolePresenter.DisplayMessage(consumeResult);

                        var kafkaConsumer = new ReservaService(_context);

                        kafkaConsumer.CrearReserva(consumeResult.Message.Value);
                    }
                    catch (ConsumeException e)
                    {
                        ConsolePresenter.DisplayErrorMessage(e.Error.Reason);
                    }
                }
            }
        }


    }
}
