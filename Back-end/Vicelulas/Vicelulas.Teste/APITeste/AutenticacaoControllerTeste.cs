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
    public class AutenticacaoControllerTeste
    {
        [Fact]
        public void RetornaStatusOkPost()
        {
            int valorEsperado = 200;

            var login = new LoginInput
            {
                Email = "Alpha@viceri.com",
                Senha = "123Aa321"
            };

            var repoMock = new Mock<IAutenticacaoNegocio>();

            var _autenticacaoController = new AutenticacaoController(repoMock.Object);

            // Act
            var actionResult = _autenticacaoController.Entrar(login);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
    }
}
