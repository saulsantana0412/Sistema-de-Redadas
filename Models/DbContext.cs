using Microsoft.EntityFrameworkCore;

namespace Proyecto_Final.Models
{
    public class MigracionContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Redada> Redadas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Redadas.db");
        }

    }
}
