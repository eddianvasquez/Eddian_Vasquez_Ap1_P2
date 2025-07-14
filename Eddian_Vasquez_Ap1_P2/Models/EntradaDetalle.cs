using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_p2.Contexto;
using Eddian_Vasquez_Ap1_p2.Models;
using System.Linq.Expressions;
using static Eddian_Vasquez_Ap1_P2.Components.Pages.VentasPages.Index;

namespace Eddian_Vasquez_Ap1_p2.Services
{
    public class EntradaDetalleServices(IDbContextFactory<Contexto> DbFactory)
    {
        // Listar todos los detalles según criterio
        public async Task<List<Detalle>> Listar(Expression<Func<Detalle, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Detalles
                .Include(d => d.Producto)
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        // Eliminar un detalle por ID
        public async Task<bool> Eliminar(int detalleId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            var detalle = await contexto.Detalles
                .Include(d => d.Producto)
                .FirstOrDefaultAsync(d => d.DetalleId == detalleId);

            if (detalle != null)
            {
                contexto.Detalles.Remove(detalle);
                await contexto.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Agregar un nuevo detalle
        public async Task<bool> Agregar(Detalle detalle)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            await contexto.Detalles.AddAsync(detalle);
            await contexto.SaveChangesAsync();
            return true;
        }

        // Obtener un detalle por ID
        public async Task<Detalle?> Buscar(int detalleId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Detalles
                .Include(d => d.Producto)
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.DetalleId == detalleId);
        }
    }
}

