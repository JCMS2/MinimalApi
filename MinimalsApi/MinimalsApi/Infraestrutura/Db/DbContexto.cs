using Microsoft.EntityFrameworkCore;
using MinimalsApi.Dominio.Entidades;

namespace MinimalsApi.Infraestrutura.Db
{
    public class MeuDbContexto : DbContext
    {
        public MeuDbContexto(DbContextOptions<MeuDbContexto> options) : base(options) { }

        public DbSet<Adminstrador> Administradores { get; set; } = default!;
        public DbSet<Veiculo> Veiculos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminstrador>().HasData(
                new Adminstrador
                {
                    Id=-1,
                    Email = "adm@teste.com",
                    Senha = "123456",
                    Perfil = "Adm"
                });
        }
    }
}
