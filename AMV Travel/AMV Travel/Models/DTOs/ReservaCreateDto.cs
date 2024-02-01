using AMV_Travel.Models.Clases;
using AMV_Travel.Models.Enumerables;
using System.Text.Json.Serialization;

namespace AMV_Travel.Models.DTOs
{
    public class ReservaCreateDto
    {
        public int ClienteId { get; set; }
        public int PaqueteId { get; set; }
    }
}
