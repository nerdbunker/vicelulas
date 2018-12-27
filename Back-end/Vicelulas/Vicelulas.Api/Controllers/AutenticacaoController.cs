using System.Net;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
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

        /// <summary>
        /// EndPoints Autenticação API
        /// </summary>
        public AutenticacaoController()
        {
            _autenticacaoNegocio = new AutenticacaoNegocio();
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
        [ProducesResponseType(typeof(PessoaDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public IActionResult Cadastrar([FromBody]LoginInput input)
        {
            return Ok();
        }
    }
}
