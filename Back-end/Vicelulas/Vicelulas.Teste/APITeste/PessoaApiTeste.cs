﻿using Xunit;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Controllers;
using Viceluas.Dominio.Exceções;
using Vicelulas.Api.Model;

namespace Vicelulas.Teste.APITeste
{
    public class PessoaApiTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {
            PessoaController pessoaController = new PessoaController();
            int valorEsperado = 200;

            var actionResult = pessoaController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {
            PessoaController pessoaController = new PessoaController();
            int id = 1;
            int valorEsperado = 200;

            var actionResult = pessoaController.GetId(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            PessoaController pessoaController = new PessoaController();

            int id = 0;

            Assert.Throws<NaoEncontradoException>(() => pessoaController.GetId(id));
        }

        [Fact]
        public void RetornaStatusOKGetIdSquad()
        {
            PessoaController pessoaController = new PessoaController();
            int id = 1;
            int valorEsperado = 200;

            var actionResult = pessoaController.GetIdSquad(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKGetName()
        {
            PessoaController pessoaController = new PessoaController();

            var nome = "a";
            int valorEsperado = 200;

            var actionResult = pessoaController.GetName(nome);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPost()
        {
            SquadController _squadController = new SquadController();
            int valorEsperado = 201;

            var objSquad = new SquadInput()
            {
                Id_tribo = 5,
                Nome = "Teste26",
                Ativo = true
            };

            var actionResult = _squadController.Post(objSquad);

            var okObjectResult = (CreatedAtRouteResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPut()
        {
            PessoaController _pessoaController = new PessoaController();
            int valorEsperado = 202;

            int Id = 1285;

            var objPessoa = new PessoaInput()
            {
                Id_squads = 24,
                Id_login = 8,
                Id_papel = 7,
                Id_unidade = 3,
                Ativo = true,
                Nome = "Testando",
                Email = "teste@teste",
                Permissao = 1,
            };

            var actionResult = _pessoaController.Put(Id, objPessoa);

            var okObjectResult = (AcceptedResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }
    }
}
