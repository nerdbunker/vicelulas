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
    public class PapelControllerTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {

            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<IPapelNegocio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Papel);
            var _papelController = new PapelController(repoMock.Object);

            // Act
            var actionResult = _papelController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
    }
}
