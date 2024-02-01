using AMV_Travel.Models.Clases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AMV_Travel.DataAccess.Seeds
{
    public class PaqueteSeed : IEntityTypeConfiguration<Paquete>
    {
        public void Configure(EntityTypeBuilder<Paquete> builder)
        {
            builder.HasData(
                new Paquete
                {
                    Id = 1,
                    Descripcion = "Paquete Aventura",
                    ExcursionId = 1,
                    HotelId = 1
                },
                new Paquete
                {
                    Id = 2,
                    Descripcion = "Paquete Histórico",
                    ExcursionId = 2,
                    HotelId = 2
                },
                new Paquete
                {
                    Id = 3,
                    Descripcion = "Paquete Naturaleza",
                    ExcursionId = 3,
                    HotelId = 3
                },
                new Paquete
                {
                    Id = 4,
                    Descripcion = "Paquete Romántico",
                    ExcursionId = 4,
                    HotelId = 4
                },
                new Paquete
                {
                    Id = 5,
                    Descripcion = "Paquete Relax",
                    ExcursionId = 5,
                    HotelId = 5
                }
            );
        }
    }
}
