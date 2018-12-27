using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class UnidadeController: ControllerBase
    {
        private readonly UnidadeNegocio _unidadeNegocio;

        /// <summary>
        /// EndPoints Unidade API
        /// </summary>
        public UnidadeController()
        {
            _unidadeNegocio = new UnidadeNegocio();

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
