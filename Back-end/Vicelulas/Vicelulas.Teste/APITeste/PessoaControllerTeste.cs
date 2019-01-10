using Xunit;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Api.Model;
using Moq;
using Vicelulas.Negocio;
using Vicelulas.DBMock;
using Vicelulas.Dominio.Dto;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace Vicelulas.Teste.APITeste
{
    public class PessoaControllerTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {

            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<IPessoaNegocio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Pessoa);
            var _pessoaController = new PessoaController(repoMock.Object);

            // Act
            var actionResult = _pessoaController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {

            // Arrange
            int valorEsperado = 200;

            var pessoa = new PessoaDto
            {
                Id = 1,
                Id_Papel = 1,
                Nome = "Pedro Aviador",
                Email = "Pedro@viceri.com",
                Cargo = "Estagiario",
                Ativo = true,
                Id_Squads = 1,
                Id_Tribo = 1,
                Id_Unidade = 1,
                Permissao = 1,
                SquadNome = "NerdBunker",
                TriboNome = "Formacao",
                Unidade = "General Osorio"
            };

            var repoMock = new Mock<IPessoaNegocio>();
            Expression<Func<IPessoaNegocio, PessoaDto>> call = x => x.SelecionarPorId(pessoa.Id);
            repoMock.Setup(call).Returns(pessoa).Verifiable("Metodo nao chamado");
            var _pessoaController = new PessoaController(repoMock.Object);


            // Act
            var actionResult = _pessoaController.GetId(pessoa.Id);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
            repoMock.Verify(call, Times.Once);
        }

        [Fact]
        public void RetornaStatusOKGetIdSquad()
        {
            // Arrange
            int valorEsperado = 200;

            var IdSquads = 1;

            var repoMock = new Mock<IPessoaNegocio>();
            Expression<Func<IPessoaNegocio, IEnumerable<PessoaDto>>> call = x => x.SelecionarPorIdSquad(IdSquads);
            repoMock.Setup(call).Returns(DbMock.Pessoa).Verifiable("Metodo nao chamado");
            var _pessoaController = new PessoaController(repoMock.Object);


            // Act
            var actionResult = _pessoaController.GetIdSquad(IdSquads);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
            repoMock.Verify(call, Times.Once);
        }

        [Fact]
        public void RetornaStatusOKGetName()
        {
            // Arrange
            int valorEsperado = 200;

            var Nome = "Pedro Aviador";

            var repoMock = new Mock<IPessoaNegocio>();
            Expression<Func<IPessoaNegocio, IEnumerable<PessoaDto>>> call = x => x.SelecionarPorNome(Nome);
            repoMock.Setup(call).Returns(DbMock.Pessoa).Verifiable("Metodo nao chamado");
            var _pessoaController = new PessoaController(repoMock.Object);

            // Act
            var actionResult = _pessoaController.GetName(Nome);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
            repoMock.Verify(call, Times.Once);
        }

        [Fact]
        public void RetornaStatusAcceptedPut()
        {
            // Arrange
            int valorEsperado = 202;

            var Id = 2;
            var pessoa = new PessoaInput()
            {
                Nome = "Fernando",
                Email = "fsilva@viceri.com",
                Id_papel = 2,
                Id_squads = 2,
                Id_unidade = 1,
                Permissao = 2,
            };

            var repoMock = new Mock<IPessoaNegocio>();

            var _pessoaController = new PessoaController(repoMock.Object);

            // Act
            var actionResult = _pessoaController.Put(Id, pessoa);
            var okObjectResult = (AcceptedResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusAcceptedPutDesativar()
        {
            // Arrange
            int valorEsperado = 202;

            var Id = 1;

            var repoMock = new Mock<IPessoaNegocio>();

            var _pessoaController = new PessoaController(repoMock.Object);

            // Act
            var actionResult = _pessoaController.PutDesativar(Id);
            var okObjectResult = (AcceptedResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusCreatedPost()
        {
            int valorEsperado = 201;

            var pessoa = new PessoaInput()
            {
                Nome = "Brito",
                Email = "mbrito@viceri.com",
                Id_papel = 1,
                Id_squads = 1,
                Id_unidade = 1,
                Permissao = 1
            };

            var repoMock = new Mock<IPessoaNegocio>();

            var _pessoaController = new PessoaController(repoMock.Object);

            // Act
            var actionResult = _pessoaController.Cadastrar(pessoa);
            var okObjectResult = (CreatedAtRouteResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
    }
}
