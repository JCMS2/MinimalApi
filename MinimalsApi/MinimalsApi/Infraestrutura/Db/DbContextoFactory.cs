using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MinimalsApi.Infraestrutura.Db
{
    public class DbContextoFactory : IDesignTimeDbContextFactory<MeuDbContexto>
    {
        public MeuDbContexto CreateDbContext(string[] args)
        {
            // Caminho direto da pasta onde está seu appsettings.json
            var basePath = @"C:\Users\Comercial\Desktop\Zé\C#\Bootcamp-Avanade\ProjetosBootcamp\ProjetoMinimalsApi\MinimalApi\MinimalsApi\MinimalsApi";

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MeuDbContexto>();

            var stringConexao = configuration.GetConnectionString("mysql");

            optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)) ;

            return new MeuDbContexto(optionsBuilder.Options);
        }
    }
}
