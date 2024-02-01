using AMV_Travel___Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace AMV_Travel___Hotel.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PC;Database=AMV_Travel_Hotel;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}
