using MinimalsApi.Dominio.DTOs;
using MinimalsApi.Dominio.Entidades;

namespace MinimalsApi.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Adminstrador? Login(LoginDTO loginDTO);
        Adminstrador? Incluir(Adminstrador administrador);
        Adminstrador? BuscarPorId (int Id);
        List<Adminstrador> Todos(int? pagina);
    }
}
