﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Dominio;
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
        [Route("{id}", Name = "PessoaGetId")]
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

        /// <summary>
        /// Método que insere uma Pessoa
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody] PessoaInput input)
        {
            var objPessoa = new Pessoa()
            {
                Id_login = input.Id_login,
                Nome = input.Nome,
                Id_squad = input.Id_squads,
                Id_papel = input.Id_papel,
                Id_unidade = input.Id_unidade,
                Email = input.Email,
                Permissao = input.Permissao,
                Ativo = true

            };

            var idPessoa = _pessoaNegocio.Inserir(objPessoa);
            objPessoa.Id = idPessoa;

            return CreatedAtRoute(routeName: "PessoaGetId", routeValues: new { id = objPessoa.Id }, value: objPessoa);
        }

        /// <summary>
        /// Método que altera uma Pessoa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromRoute]int id, [FromBody]PessoaInput input)
        {
            var objPessoa = new Pessoa()
            {
                Nome = input.Nome,
                Email = input.Email,
                Id_squad = input.Id_squads,
                Id_papel = input.Id_papel,
                Id_login = input.Id_login,
                Id_unidade = input.Id_unidade,
                Permissao = input.Permissao
            };

            var retorno = _pessoaNegocio.Alterar(id, objPessoa);
            return Accepted(retorno);
        }

        /// <summary>
        /// Método que Desativa uma Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut("update/{id}")]
        [ProducesResponseType(typeof(Pessoa), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult PutDesativar([FromRoute] int id, [FromBody] PessoaInput input)
        {
            var objPessoa = new Pessoa()
            {
                Nome = input.Nome,
                Email = input.Email,
                Id_squad = input.Id_squads,
                Id_papel = input.Id_papel,
                Id_login = input.Id_login,
                Id_unidade = input.Id_unidade,
                Permissao = input.Permissao,
                Ativo = false
            };
            var retorno = _pessoaNegocio.Desativar(id, objPessoa);
            return Accepted(retorno);
        }
    }
}