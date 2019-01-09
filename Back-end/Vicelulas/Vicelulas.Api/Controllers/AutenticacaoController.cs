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
        private readonly IAutenticacaoNegocio _autenticacaoNegocio;

        /// <summary>
        /// EndPoints Autenticação API
        /// </summary>
        public AutenticacaoController(IAutenticacaoNegocio _autenticacaoNegocio)
        {
            this._autenticacaoNegocio = _autenticacaoNegocio;

        }

        /// <summary>
        /// Método que realiza login no sistema
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Entrar")]
        [ProducesResponseType(typeof(PessoaDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public IActionResult Entrar([FromBody]PessoaInput input)
        {
            var obj = _autenticacaoNegocio.Entrar(input.Email, input.Senha);

            return Ok(obj);
        }







    }
}
