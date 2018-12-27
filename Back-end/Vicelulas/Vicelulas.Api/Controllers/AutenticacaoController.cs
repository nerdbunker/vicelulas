using System.Net;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly AutenticacaoNegocio _autenticacaoNegocio;
        private readonly PessoaNegocio _pessoaNegocio;

        /// <summary>
        /// EndPoints Autenticação API
        /// </summary>
        public AutenticacaoController()
        {
            _autenticacaoNegocio = new AutenticacaoNegocio();
            _pessoaNegocio = new PessoaNegocio();
        }

        /// <summary>
        /// Método que realiza login no sistema
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Entrar")]
        [ProducesResponseType(typeof(PessoaDto),(int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public IActionResult Entrar([FromBody]LoginInput input)
        {
            var obj = _autenticacaoNegocio.Entrar(input.username, input.password);

            return Ok(obj);
        }


        /// <summary>
        /// Método que cadastra usuário no sistema
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Cadastrar")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public IActionResult Cadastrar([FromBody]CadastroPessoaInput input)
        {
            var objLogin = new Login()
            {
                Username = input.Email,
                Password = "123Aa321" 

            };

            var idLogin = _autenticacaoNegocio.Cadastrar(objLogin);
            

            var objPessoa = new Pessoa()
            {
                Id_login = idLogin,
                Nome = input.Nome,
                Id_squad = input.Id_squads,
                Id_papel = input.Id_papel,
                Id_unidade = input.Id_unidade,
                Email = input.Email,
                Permissao = 1,
                Ativo = true

            };

            var idPessoa = _pessoaNegocio.Inserir(objPessoa);
            objPessoa.Id = idPessoa;

            //Refenciar Rota
            return CreatedAtRoute(routeName: "PessoaGetId", routeValues: new { id = objPessoa.Id }, value: objPessoa);
        }



     
    }
}
