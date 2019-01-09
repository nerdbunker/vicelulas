using Xunit;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Negocio;
using Vicelulas.DBMock;
using Moq;
using Vicelulas.Dominio.Dto;
using System;
using System.Linq.Expressions;

namespace Vicelulas.Teste.APITeste
{
    public class TriboControllerTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {

            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<ITriboNegocio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Tribo);
            var _triboController = new TriboController(repoMock.Object);

            // Act
            var actionResult = _triboController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {

            // Arrange
            int valorEsperado = 200;

            var tribo = new TriboDto
            {
                Id = 1,
                Nome = "Formacao",
                Ativo = true
            };

            var repoMock = new Mock<ITriboNegocio>();
            Expression<Func<ITriboNegocio, TriboDto>> call = x => x.SelecionarPorId(tribo.Id);
            repoMock.Setup(call).Returns(tribo).Verifiable("Metodo nao chamado");
            var _triboController = new TriboController(repoMock.Object);


            // Act
            var actionResult = _triboController.GetId(tribo.Id);
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

            var Nome = "Formacao";

            var repoMock = new Mock<ITriboNegocio>();
            repoMock.Setup(x => x.SelecionarPorNome(Nome)).Returns(DbMock.Tribo);

            var _triboController = new TriboController(repoMock.Object);

            // Act
            var actionResult = _triboController.GetName(Nome);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusCreatedPost()
        {
            int valorEsperado = 201;

            var tribo = new TriboInput
            {
                Nome = "Teste",
                Ativo = true
            };

            var repoMock = new Mock<ITriboNegocio>();

            var _triboController = new TriboController(repoMock.Object);

            // Act
            var actionResult = _triboController.Post(tribo);
            var okObjectResult = (CreatedAtRouteResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusAcceptedPut()
        {
            // Arrange
            int valorEsperado = 202;

            var Id = 2;
            var tribo = new TriboInput()
            {
                Nome = "Atualiza",
                Ativo = true
            };

            var repoMock = new Mock<ITriboNegocio>();

            var _triboController = new TriboController(repoMock.Object);

            // Act
            var actionResult = _triboController.Put(Id, tribo);
            var okObjectResult = (AcceptedResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusAcceptedPutDesativar()
        {
            // Arrange
            int valorEsperado = 202;

            var Id = 2;

            var repoMock = new Mock<ITriboNegocio>();

            var _triboController = new TriboController(repoMock.Object);

            // Act
            var actionResult = _triboController.PutDesativar(Id);
            var okObjectResult = (AcceptedResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
    }
}
