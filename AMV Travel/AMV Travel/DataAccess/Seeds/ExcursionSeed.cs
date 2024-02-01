using AMV_Travel.Models.Clases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AMV_Travel.DataAccess.Seeds
{
    public class ExcursionSeed : IEntityTypeConfiguration<Excursion>
    {
        public void Configure(EntityTypeBuilder<Excursion> builder)
        {
            builder.HasData(
                new Excursion { Id = 1, Descripcion = "Aventura en la montaña", Precio = 100, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(2) },
                new Excursion { Id = 2, Descripcion = "Tour histórico", Precio = 150, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) },
                new Excursion { Id = 3, Descripcion = "Exploración de la selva", Precio = 120, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(4) },
                new Excursion { Id = 4, Descripcion = "Viaje en globo aerostático", Precio = 200, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(5) },
                new Excursion { Id = 5, Descripcion = "Recorrido en bicicleta", Precio = 180, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(6) }
            );
        }
    }
}
