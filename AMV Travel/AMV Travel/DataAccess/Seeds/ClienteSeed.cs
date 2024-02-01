using AMV_Travel.Models.Clases;
using AMV_Travel.Models.Enumerables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AMV_Travel.DataAccess.Seeds
{
    public class ClienteSeed : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente { Id = 1, Nombre = "Lucas", Apellido = "García", Correo = "lucas@example.com", Telefono = "123456789" },
                new Cliente { Id = 2, Nombre = "Martín", Apellido = "Pérez", Correo = "martin@example.com", Telefono = "987654321" },
                new Cliente { Id = 3, Nombre = "Nicolas", Apellido = "Rodríguez", Correo = "nicolas@example.com", Telefono = "555555555" },
                new Cliente { Id = 4, Nombre = "Alejandra", Apellido = "López", Correo = "alejandra@example.com", Telefono = "666666666" },
                new Cliente { Id = 5, Nombre = "Camila", Apellido = "Fernández", Correo = "camila@example.com", Telefono = "777777777" }
            );
        }
    }
}
