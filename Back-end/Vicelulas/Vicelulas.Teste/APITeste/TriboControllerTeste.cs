using Xunit;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Negocio;
using Vicelulas.DBMock;
using Moq;

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


    }
}
