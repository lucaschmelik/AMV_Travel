using AMV_Travel.Models.Enumerables;
using System.Text.Json.Serialization;

namespace AMV_Travel.Models.Clases
{
    public class Reserva
    {
        public int Id { get; set; }
        public EstadoReservaEnum Estado { get; set; }
        public Cliente Cliente { get; set; }
        [JsonIgnore]
        public int ClienteId { get; set; }
        public Paquete Paquete { get; set; }
        [JsonIgnore]
        public int PaqueteId { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
