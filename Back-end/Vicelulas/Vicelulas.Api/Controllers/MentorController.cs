using System.Net;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Dominio;
using Vicelulas.Negocio;


namespace Vicelulas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {

        private readonly IMentorNegocio _mentorNegocio;

        /// <summary>
        /// EndPoints Mentor API
        /// </summary>
        public MentorController(IMentorNegocio _mentorNegocio)
        {
            this._mentorNegocio = _mentorNegocio;
        }

        /// <summary>
        /// Método que obtem uma lista de mentores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]

        public IActionResult Get()
        {
            return Ok(_mentorNegocio.Selecionar());
        }


    }
}