using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_p2.Models;
using System.Linq.Expressions;
using Eddian_Vasquez_Ap1_P2.Contexto;
using System.Linq;


namespace Eddian_Vasquez_Ap1_p2.Services
{
    public class EntradasServices(IDbContextFactory<Contexto> DbFactory)
    {
        // Listar todas las entradas según un criterio
        public async Task<List<Entrada>> Listar(Expression<Func<Entrada, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Entradas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        // Buscar entrada por ID
        public async Task<Entrada?> Buscar(int entradaId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Entradas
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.EntradaId == entradaId);
        }

        // Agregar nueva entrada
        public async Task<bool> Agregar(Entrada entrada)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            await contexto.Entradas.AddAsync(entrada);
            await contexto.SaveChangesAsync();
            return true;
        }

        // Editar entrada existente
        public async Task<bool> Editar(Entrada entrada)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Entradas.Update(entrada);
            await contexto.SaveChangesAsync();
            return true;
        }

        // Eliminar entrada por ID
        public async Task<bool> Eliminar(int entradaId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            var entrada = await contexto.Entradas.FindAsync(entradaId);
            if (entrada != null)
            {
                contexto.Entradas.Remove(entrada);
                await contexto.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
