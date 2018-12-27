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
        private readonly PapelNegocio _papelNegocio;


        /// <summary>
        /// EndPoints Papel API
        /// </summary>
        public PapelController()
        {
            _papelNegocio = new PapelNegocio();

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
