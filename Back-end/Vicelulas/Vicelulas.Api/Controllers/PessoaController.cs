using System.Net;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Dominio;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaNegocio _pessoaNegocio;

        /// <summary>
        /// EndPoints Pessoa API
        /// </summary>
        public PessoaController()
        {
            _pessoaNegocio = new PessoaNegocio();
        }

        /// <summary>
        /// Método que obtem uma lista de pessoas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_pessoaNegocio.Selecionar());
        }

        /// <summary>
        /// Método que seleciona uma pessoa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "PessoaGetId")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _pessoaNegocio.SelecionarPorId(id);

            return Ok(obj);
        }

        /// <summary>
        /// Método que obtem lista de pessoas por squad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("squad/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetIdSquad(int id)
        {
            var obj = _pessoaNegocio.SelecionarPorIdSquad(id);

            return Ok(obj);
        }

        /// <summary>
        /// Método que obtem lista de pessoas com o determinado nome (pesquisa)
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisar/{nome}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetName(string nome)
        {
            var obj = _pessoaNegocio.SelecionarPorNome(nome);

            return Ok(obj);
        }


        /// <summary>
        /// Método que altera uma Pessoa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromRoute]int id, [FromBody]PessoaInput input)
        {
            var objPessoa = new Pessoa()
            {
                Nome = input.Nome,
                Email = input.Email,
                Id_squad = input.Id_squads,
                Id_papel = input.Id_papel,
                Id_unidade = input.Id_unidade,
                Permissao = input.Permissao,
                Ativo = true
            };

            var retorno = _pessoaNegocio.Alterar(id, objPessoa);
            return Accepted(retorno);
        }

        /// <summary>
        /// Método que Desativa/Ativa uma Pessoa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("MudarAtivo/{id}")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult PutDesativar([FromRoute] int id)
        {
            
            _pessoaNegocio.AtivarDesativarPessoa(id);
            return Accepted();
        }

     
    }
}