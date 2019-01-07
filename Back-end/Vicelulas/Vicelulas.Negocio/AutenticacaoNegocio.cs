
using System;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dominio.Seguranca;

namespace Vicelulas.Negocio
{
    public class AutenticacaoNegocio : IAutenticacaoNegocio
    {

        private readonly IAutenticacaoRepositorio _autenticacaoRepositorio;

        public AutenticacaoNegocio(IAutenticacaoRepositorio _autenticacaoRepositorio)
        {
            this._autenticacaoRepositorio = _autenticacaoRepositorio;
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
