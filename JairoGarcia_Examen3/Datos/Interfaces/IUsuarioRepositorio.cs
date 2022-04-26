using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<bool> ValidaUsuario(Login login);

        Task<Usuario> GetPorCodigo(string codigo);
    }


}