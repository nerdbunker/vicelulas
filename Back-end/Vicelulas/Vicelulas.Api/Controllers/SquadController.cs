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
    public class SquadController : ControllerBase
    {
        private readonly ISquadNegocio _squadNegocio;


        /// <summary>
        /// EndPoints Squad API
        /// </summary>
        public SquadController(ISquadNegocio _squadNegocio)
        {
            this._squadNegocio = _squadNegocio;
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
        /// Método que obtem uma lista de squads sem tribo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("SemTribo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetPorSquadSemTribo()
        {
            return Ok(_squadNegocio.SelecionarSquadsSemTribo());
        }

        /// <summary>
        /// Método que seleciona uma squad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "SquadGetId")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetId(int id)
        {
            var obj = _squadNegocio.SelecionarPorId(id);
         

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

            return Ok(obj);
        }

        /// <summary>
        /// Método que insere uma Squad.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Squad), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody] SquadInput input)
        {
            var objSquad = new Squad()
            {
                Nome = input.Nome,
                Id_tribo = input.Id_tribo,
                Ativo = true

            };

            var idSquad = _squadNegocio.Inserir(objSquad);
            objSquad.Id = idSquad;

            return CreatedAtRoute(routeName: "SquadGetId", routeValues: new { id = objSquad.Id }, value: objSquad);
        }

        /// <summary>
        /// Método que altera uma Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(Squad), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromRoute]int id, [FromBody]SquadInput input)
        {
            var objSquad = new Squad()
            {
                Nome = input.Nome,
                Id_tribo = input.Id_tribo
            };

            var retorno = _squadNegocio.Alterar(id, objSquad);
            return Accepted(retorno);
        }

        /// <summary>
        /// Método que Desativa/Ativa uma Squad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("MudarAtivo/{id}")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult PutDesativar([FromRoute] int id)
        {

            _squadNegocio.AtivarDesativarSquad(id);
            return Accepted();
        }
    }
}