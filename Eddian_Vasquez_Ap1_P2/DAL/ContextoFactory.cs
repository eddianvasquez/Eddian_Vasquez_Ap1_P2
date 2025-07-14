using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Re.Context;

namespace Adrian_Hernandez_Bonilla_P1_Ap1.Context
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("workstation id=vamosapasar.mssql.somee.com;packet size=4096;user id=pollito_SQLLogin_1;pwd=6jmfstvuoj;data source=vamosapasar.mssql.somee.com;persist security info=False;initial catalog=vamosapasar;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }
}