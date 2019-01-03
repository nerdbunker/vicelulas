using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public interface IAutenticacaoNegocio
    {

        PessoaDto Entrar(string username, string password);
    }
}