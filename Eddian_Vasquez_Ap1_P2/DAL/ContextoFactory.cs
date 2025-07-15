using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Eddian_Vasquez_Ap1_P2.Data; 

public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
{
    public Contexto CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<Contexto>();

        optionsBuilder.UseSqlServer("workstation id=vamospapa.mssql.somee.com;packet size=4096;user id=pollito_SQLLogin_1;pwd=6jmfstvuoj;data source=vamospapa.mssql.somee.com;persist security info=False;initial catalog=vamospapa;TrustServerCertificate=True");

        return new Contexto(optionsBuilder.Options);
    }
}
