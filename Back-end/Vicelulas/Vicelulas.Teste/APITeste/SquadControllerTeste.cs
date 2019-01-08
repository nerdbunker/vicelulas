using Xunit;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Negocio;
using Moq;
using Vicelulas.DBMock;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dado;
using System.Linq.Expressions;
using System;
using Vicelulas.Dominio;
using System.Collections.Generic;

namespace Vicelulas.Teste.APITeste
{
    public class SquadControllerTeste
    {

        [Fact]
        public void RetornaStatusOKGetAll()
        {
            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<ISquadNegocio>();

            Expression<Func<ISquadNegocio, IEnumerable<SquadDto>>> call = x => x.Selecionar();
            repoMock.Setup(call).Returns(DbMock.Squad);
            var _squadController = new SquadController(repoMock.Object);

            // Act
            var actionResult = _squadController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {

            // Arrange
            int valorEsperado = 200;

            var squad = new SquadDto
            {
                Id = 1,
                Id_Tribo = 1,
                Nome = "NerdBunker",
                NomeTribo = "Formacao",
                Ativo = true
            };
            var repoMock = new Mock<ISquadNegocio>();
            Expression<Func<ISquadNegocio, SquadDto>> call = x => x.SelecionarPorId(squad.Id);
            repoMock.Setup(call).Returns(squad).Verifiable("Metodo nao chamado");
            var _squadController = new SquadController(repoMock.Object);


            // Act
            var actionResult = _squadController.GetId(squad.Id);
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

            var Nome = "NerdBunker";        

            var repoMock = new Mock<ISquadNegocio>();
            repoMock.Setup(x => x.SelecionarPorNome(Nome)).Returns(DbMock.Squad);

            var _squadController = new SquadController(repoMock.Object);

            // Act
            var actionResult = _squadController.GetName(Nome);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void MocaEventoAposAcao()
        {

        }

    }
}
