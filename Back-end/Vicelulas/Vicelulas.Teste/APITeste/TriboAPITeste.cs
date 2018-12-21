using System.Collections.Generic;
using Xunit;
using Vicelulas.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Viceluas.Dominio.Dto;

namespace Vicelulas.Teste.APITeste
{
    public class TriboAPITeste
    {
        [Fact]
        public void WorkGetAll()
        {
            TriboController _triboController = new TriboController();
            int valorEsperado = 200;

            var actionResult = _triboController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }
    }
}
