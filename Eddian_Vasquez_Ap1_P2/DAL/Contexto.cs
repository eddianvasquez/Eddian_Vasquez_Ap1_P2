using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_p2.Models;

namespace Re.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Productos>().HasData(new List<Productos>
            {
                new Productos { ProductoId = 1, Nombre = "Maní", Peso = 5 },
                new Productos { ProductoId = 2, Nombre = "Almendra", Peso = 10 },
                new Productos { ProductoId = 3, Nombre = "Pistacho", Peso = 15 }
            });
        }
    }
}
