using AMV_Travel___Hotel.DataAccess.Context;
using AMV_Travel___Hotel.Models;
using AMV_Travel___Hotel.Models.DTO;
using Newtonsoft.Json;

namespace AMV_Travel___Hotel.Services
{
    public class ReservaService
    {
        private readonly ApplicationDbContext _context;

        public ReservaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CrearReserva(string kafkaResult)
        {
            var hotelFromKafkaDto = JsonConvert.DeserializeObject<HotelFromKafkaDto>(kafkaResult);

            var reserva = new Reserva
            {
                Hotel = hotelFromKafkaDto.Hotel.Nombre,
                Cliente = $"{hotelFromKafkaDto.Cliente.Nombre} {hotelFromKafkaDto.Cliente.Apellido}",
                FechaIngreso = hotelFromKafkaDto.Hotel.FechaInicio,
                FechaEgreso = hotelFromKafkaDto.Hotel.FechaFin,
                PrecioEstadia = (int)(hotelFromKafkaDto.Hotel.FechaFin - hotelFromKafkaDto.Hotel.FechaInicio).TotalDays * hotelFromKafkaDto.Hotel.Precio
            };

            _context.Reservas.Add(reserva);

            _context.SaveChanges();
        }
    }
}
