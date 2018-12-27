using Microsoft.AspNetCore.Mvc;
using Vicelulas.Negocio;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;
using Vicelulas.Dominio;
using Vicelulas.Api.Model;
using Microsoft.AspNetCore.JsonPatch;

namespace Vicelulas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/organismo/[controller]")]
    [ApiController]
    public class TriboController : ControllerBase
    {
        private readonly TriboNegocio _triboNegocio;


        /// <summary>
        /// EndPoints Tribo API
        /// </summary>
        public TriboController()
        {
            _triboNegocio = new TriboNegocio();

        }

        /// <summary>
        /// Método que obtem uma lista de tribos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_triboNegocio.Selecionar());
        }

        /// <summary>
        /// Método que seleciona uma tribo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "TriboGetId")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _triboNegocio.SelecionarPorId(id);

            return Ok(obj);
        }


        /// <summary>
        /// Método que obtem lista de tribos com o determinado nome (pesquisa)
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pesquisar/{nome}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetName(string nome)
        {
            var obj = _triboNegocio.SelecionarPorNome(nome);
     
            return Ok(obj);
        }


        /// <summary>
        /// Método que insere uma Tribo.
        /// </summary>
        /// <param name="input">Objeto com os dados da Tribo.</param>
        /// <returns> Retorna um código de status Created, HTTP 201, Retorna um código de status BadRequest, HTTP 400, ou Retorna um codigo de status InternalServerError, HTTP 500.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Tribo), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody] TriboInput input)
        {
            var objTribo = new Tribo()
            {
                Nome = input.Nome,
                Ativo = true

            };

            var idTribo = _triboNegocio.Inserir(objTribo);
            objTribo.Id = idTribo;

            return CreatedAtRoute(routeName: "TriboGetId", routeValues: new { id = objTribo.Id },value: objTribo);

        }

        /// <summary>
        /// Método que altera uma Tribo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(Tribo), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromRoute]int id, [FromBody] TriboInput input)
        {
            var objTribo = new Tribo()
            {
                Ativo = input.Ativo,
                Nome = input.Nome
            };

            var retorno = _triboNegocio.Alterar(id, objTribo);
            return Accepted(retorno);
        }

        /// <summary>
        /// Método que Desativa uma Tribo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut("update/{id}")]
        [ProducesResponseType(typeof(Tribo), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult PutDesativar([FromRoute] int id, [FromBody] TriboInput input)
        {
            var objTribo = new Tribo()
            {
                Ativo = false,
                Nome = input.Nome
            };
            var retorno = _triboNegocio.Desativar(id, objTribo);
            return Accepted(retorno);
        }

    }
}