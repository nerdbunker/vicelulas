using Xunit;
using Vicelulas.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Vicelulas.Teste.APITeste
{
    public class TriboApiTeste
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
