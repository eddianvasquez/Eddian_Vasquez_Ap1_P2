using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Eddian_Vasquez_Ap1_p2.Context;


namespace Eddian_Vasquez_Ap1_p2.Context
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("workstation id=vamosplis.mssql.somee.com;packet size=4096;user id=pollito_SQLLogin_1;pwd=6jmfstvuoj;data source=vamosplis.mssql.somee.com;persist security info=False;initial catalog=vamosplis;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }
}