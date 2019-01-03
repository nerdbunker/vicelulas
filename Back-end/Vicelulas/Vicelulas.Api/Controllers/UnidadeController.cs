using Microsoft.AspNetCore.Mvc;
using System.Net;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class UnidadeController: ControllerBase
    {
        private readonly IUnidadeNegocio _unidadeNegocio;
        
        /// <summary>
        /// EndPoints Unidade API
        /// </summary>
        public UnidadeController(IUnidadeNegocio _unidadeNegocio)
        {
            this._unidadeNegocio = _unidadeNegocio;

        }

        /// <summary>
        /// Método que obtem uma lista de Unidades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_unidadeNegocio.Selecionar());
        }
    }
}
