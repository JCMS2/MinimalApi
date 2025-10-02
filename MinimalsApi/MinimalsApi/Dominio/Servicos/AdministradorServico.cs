using Microsoft.EntityFrameworkCore;
using MinimalsApi.Dominio.DTOs;
using MinimalsApi.Dominio.Entidades;
using MinimalsApi.Dominio.Interfaces;
using MinimalsApi.Dominio.ModelViews;
using MinimalsApi.Infraestrutura.Db;

namespace MinimalsApi.Dominio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly MeuDbContexto _contexto;

        public AdministradorServico(MeuDbContexto contexto)
        {
            _contexto = contexto;
        }

        public Adminstrador? BuscarPorId(int id)
        {
            return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
        }

        public Adminstrador? Incluir(Adminstrador administrador)
        {
            _contexto.Administradores.Add(administrador);
            _contexto.SaveChanges();
            return administrador;
        }

        public Adminstrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
            
        }

        public List<Adminstrador> Todos(int? pagina)
        {
            var query = _contexto.Administradores.AsQueryable();
            
            int ItensPorPagina = 10;

            if (pagina != null)
                query = query.Skip((int)(pagina - 1) * ItensPorPagina).Take(ItensPorPagina);
            return query.ToList();
        }
    }
}
