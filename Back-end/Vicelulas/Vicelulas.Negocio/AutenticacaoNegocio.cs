
using System;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio;
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

        /// <param name="entity"></param>
        public int Cadastrar(Login entity)
        {
            //Verifica se os campos Email e Senha estão preenchidos
            if (String.IsNullOrEmpty(entity.Username) || String.IsNullOrEmpty(entity.Password))
                throw new ConflitoException("Usuário ou senha não estão preenchidos !");

            //Verifica se o username já existe

            int objExiste = _autenticacaoRepositorio.SelecionarPorUsername(entity.Username);
            if (objExiste != 0)
                throw new ConflitoException("Usuário já existe !");


           var pwHash = PasswordHash.Create(entity.Password);
       
           entity.Password = pwHash;

           return _autenticacaoRepositorio.Cadastrar(entity);
        }
    }
}
