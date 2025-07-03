using Microsoft.EntityFrameworkCore;
using ProyectoBD2.Config;
using ProyectoBD2.Models;

namespace ProyectoBD2.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Productor> Productores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = AppConfig.GetConnectionString();
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
