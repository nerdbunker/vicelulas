
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dominio.Seguranca;

namespace Vicelulas.Negocio
{
    public class AutenticacaoNegocio
    {
        private readonly AutenticacaoRepositorio _autenticacaoRepositorio;


        public AutenticacaoNegocio()
        {
            _autenticacaoRepositorio = new AutenticacaoRepositorio();
            
            
        }

        /// <param name="username"></param>
        /// <param name="password"></param>
        public PessoaDto Entrar(string username, string password)
        {
            var pwHash = PasswordHash.Create(password);

            var obj = _autenticacaoRepositorio.Entrar(username, pwHash);

            if (obj == null)
                throw new NaoEncontradoException("Usuário ou senha inválidos !");

            if (!obj.Ativo)
                throw new RecusadoException("Esse usuário está desativado no sistema !");

            return obj;
        }
    }
}
