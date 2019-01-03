using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public interface IAutenticacaoRepositorio
    {
        PessoaDto Entrar(string username, string password);
        int SelecionarPorUsername(string username);
    }
}