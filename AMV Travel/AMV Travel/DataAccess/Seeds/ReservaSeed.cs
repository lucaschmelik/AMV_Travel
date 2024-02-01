using AMV_Travel.Models.Clases;
using AMV_Travel.Models.Enumerables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AMV_Travel.DataAccess.Seeds
{
    public class ReservaSeed : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.HasData(
                new Reserva
                {
                    Id = 1,
                    Estado = EstadoReservaEnum.Confirmada,
                    FechaCreacion = DateTime.Now,
                    ClienteId = 1,
                    PaqueteId = 1
                },
                new Reserva
                {
                    Id = 2,
                    Estado = EstadoReservaEnum.Confirmada,
                    FechaCreacion = DateTime.Now,
                    ClienteId = 2,
                    PaqueteId = 2
                },
                new Reserva
                {
                    Id = 3,
                    Estado = EstadoReservaEnum.Cancelada,
                    FechaCreacion = DateTime.Now,
                    ClienteId = 3,
                    PaqueteId = 3
                },
                new Reserva
                {
                    Id = 4,
                    Estado = EstadoReservaEnum.Creada,
                    FechaCreacion = DateTime.Now,
                    ClienteId = 4,
                    PaqueteId = 4
                },
                new Reserva
                {
                    Id = 5,
                    Estado = EstadoReservaEnum.Creada,
                    FechaCreacion = DateTime.Now,
                    ClienteId = 5,
                    PaqueteId = 5
                }
            );
        }
    }
}


