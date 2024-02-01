namespace AMV_Travel.Models.Clases
{
    public class Excursion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
