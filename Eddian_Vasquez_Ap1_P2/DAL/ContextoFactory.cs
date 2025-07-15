using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Eddian_Vasquez_Ap1_P2.Contexto;

using Eddian_Vasquez_Ap1_P2.Contexto;

public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
{
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();

            optionsBuilder.UseSqlServer("workstation id=vamosapasar.mssql.somee.com;packet size=4096;user id=pollito_SQLLogin_1;pwd=6jmfstvuoj;data source=vamosapasar.mssql.somee.com;persist security info=False;initial catalog=vamosapasar;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }

