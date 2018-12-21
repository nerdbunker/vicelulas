using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Negocio;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class SquadController : ControllerBase
    {
        private readonly SquadNegocio _squadNegocio;


        /// <summary>
        /// EndPoints Squad API
        /// </summary>
        public SquadController()
        {
            _squadNegocio = new SquadNegocio();

        }

        /// <summary>
        /// Método que obtem uma lista de squads
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_squadNegocio.Selecionar());
        }

        /// <summary>
        /// Método que seleciona uma squad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _squadNegocio.SelecionarPorId(id);
            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        /// <summary>
        /// Método que obtem uma lista de squads por tribo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("tribo/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetIdTribo(int id)
        {
            var obj = _squadNegocio.SelecionarPorIdTribo(id);
            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        /// <summary>
        /// Método que obtem lista de squads com o determinado nome (pesquisa)
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisar/{nome}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetName(string nome)
        {
            var obj = _squadNegocio.SelecionarPorNome(nome);
            if (obj == null)
                return NotFound();

            return Ok(obj);
        }


    }
}