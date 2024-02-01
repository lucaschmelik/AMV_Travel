using AMV_Travel.Models.Clases;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AMV_Travel.DataAccess.Context
{
    public class AMVContext : DbContext
    {
        public AMVContext(DbContextOptions<AMVContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Excursion> Excursiones { get; set; }
        public DbSet<Hotel> Hoteles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
