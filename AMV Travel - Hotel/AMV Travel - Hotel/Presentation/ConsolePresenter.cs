using Confluent.Kafka;
using System;

namespace AMV_Travel___Hotel.Presentation
{
    public static class ConsolePresenter
    {
        public static void DisplayListeningMessage()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("ESCUCHANDO MENSAJES DE KAFKA...");
            Console.WriteLine("-------------------------------------------------");
        }

        public static void DisplayErrorMessage(string errorMessage)
        {
            Console.WriteLine($"Error al consumir mensaje: {errorMessage}");
        }

        public static void DisplayMessage(ConsumeResult<Ignore, string> consumeResult)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"{consumeResult.Offset} | Mensaje recibido: {consumeResult.Message.Value}");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
