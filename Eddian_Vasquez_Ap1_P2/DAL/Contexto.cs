using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_P2.Models;
using Eddian_Vasquez_Ap1_p2.Models;

namespace Eddian_Vasquez_Ap1_P2.Data 
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<EntradaDetalle> EntradaDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Entity<Entrada>()
                .HasMany(e => e.Detalles)
                .WithOne(d => d.Entrada)
                .HasForeignKey(d => d.EntradaId)
                .OnDelete(DeleteBehavior.Cascade);

           
            modelBuilder.Entity<Producto>().HasData(new List<Producto>
            {
                new Producto
                {
                    ProductoId = 1,
                    Descripcion = "Maní",
                    Peso = 5.0,
                    Existencia = 0,
                    EsCompuesto = false
                },
                new Producto
                {
                    ProductoId = 2,
                    Descripcion = "Pistacho",
                    Peso = 10.0,
                    Existencia = 0,
                    EsCompuesto = false
                },
                new Producto
                {
                    ProductoId = 3,
                    Descripcion = "Almendra",
                    Peso = 15.0,
                    Existencia = 0,
                    EsCompuesto = false
                }
            });
        }
    }
}
