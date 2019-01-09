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


    }
}
