using System;

namespace AMV_Travel___Hotel.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Hotel { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int PrecioEstadia { get; set; }
    }
}
