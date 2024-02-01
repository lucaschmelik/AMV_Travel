using AMV_Travel.Models.Clases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AMV_Travel.DataAccess.Seeds
{
    public class HotelSeed : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { Id = 1, Nombre = "Hotel Estrella", Direccion = "Calle de la Luna 123", Precio = 200, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(2) },
                new Hotel { Id = 2, Nombre = "Gran Hotel Oasis", Direccion = "Avenida del Sol 456", Precio = 250, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) },
                new Hotel { Id = 3, Nombre = "Hotel de las Montañas", Direccion = "Ruta de la Cima 789", Precio = 220, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(4) },
                new Hotel { Id = 4, Nombre = "Hotel Natura", Direccion = "Camino al Bosque 101", Precio = 300, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(5) },
                new Hotel { Id = 5, Nombre = "Hotel del Mar", Direccion = "Paseo Marítimo 202", Precio = 280, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(6) }
            );
        }
    }
}
