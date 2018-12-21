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
        [Route("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _pessoaNegocio.SelecionarPorId(id);

            if (obj == null)
                return NotFound();

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

            if (obj == null)
                return NotFound();

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
            if (obj == null)
                return NotFound();

            return Ok(obj);
        }
    }
}