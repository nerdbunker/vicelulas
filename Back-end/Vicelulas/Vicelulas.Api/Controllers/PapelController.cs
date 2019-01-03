using Microsoft.AspNetCore.Mvc;
using System.Net;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class PapelController: ControllerBase
    {
        private readonly IPapelNegocio _papelNegocio;


        /// <summary>
        /// EndPoints Papel API
        /// </summary>
        public PapelController(IPapelNegocio _papelNegocio)
        {
            this._papelNegocio = _papelNegocio;

        }

        /// <summary>
        /// Método que obtem uma lista de Papeis/Cargos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_papelNegocio.Selecionar());
        }
    }
}
