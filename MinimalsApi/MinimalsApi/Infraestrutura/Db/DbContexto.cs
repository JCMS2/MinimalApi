using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalsApi.Dominio.Entidades;

namespace MinimalsApi.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration? _configuracaoAppSettings;

        // Construtor para runtime (com configuração)
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
        }

        // Opcional, se quiser usar configuração direta no OnConfiguring (não obrigatório se usar o construtor acima)
        public DbContexto(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }

        public DbContexto()
        {
        }

        public DbSet<Adminstrador> Administradores { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminstrador>().HasData(
                new Adminstrador 
                {
                      Email= "adm@teste.com",
                      Senha= "123456",
                      Perfil= "Adm"
                }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (_configuracaoAppSettings != null)
                {
                    var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql");
                    if (!string.IsNullOrEmpty(stringConexao))
                    {
                        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
                    }
                }
            }
        }
    }
}
