using AMV_Travel___Hotel.Consumer;
using AMV_Travel___Hotel.DataAccess.Context;

namespace AMV_Travel___Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                var kafkaConsumer = new KafkaService(context);
                kafkaConsumer.ConsumeMessages();
            }
        }
    }
}
