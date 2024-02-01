using System.Text.Json.Serialization;

namespace AMV_Travel.Models.Clases
{
    public class Paquete
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Excursion? Excursion { get; set; }
        [JsonIgnore]
        public int ExcursionId { get; set; }
        public Hotel? Hotel { get; set; }
        [JsonIgnore]
        public int HotelId { get; set; }
    }
}
