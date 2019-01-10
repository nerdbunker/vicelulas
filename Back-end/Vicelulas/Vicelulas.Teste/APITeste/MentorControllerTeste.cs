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
    public class MentorControllerTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {
            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<IMentorNegocio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Mentor);
            var _mentorController = new MentorController(repoMock.Object);

            // Act
            var actionResult = _mentorController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
    }
}
