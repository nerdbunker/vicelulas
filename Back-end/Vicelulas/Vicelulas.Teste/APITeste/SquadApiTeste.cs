using Xunit;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;

namespace Vicelulas.Teste.APITeste
{
    public class SquadApiTeste
    {


        [Fact]
        public void RetornaStatusOKGetAll()
        {

            int valorEsperado = 200;

            var actionResult = _squadController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {

            int id = 1;
            int valorEsperado = 200;

            var actionResult = _squadController.GetId(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {

            int id = 0;

            Assert.Throws<NaoEncontradoException>(() => _squadController.GetId(id));
        }

        [Fact]
        public void RetornaStatusOKGetName()
        {

            var nome = "a";
            int valorEsperado = 200;

            var actionResult = _squadController.GetName(nome);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPost()
        {
  
            int valorEsperado = 201;

            var objSquad = new SquadInput()
            {
                Id_tribo = 5,
                Nome = "Teste26",
                Ativo = true
            };

            var actionResult = _squadController.Post(objSquad);

            var okObjectResult = (CreatedAtRouteResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPut()
        {
            int valorEsperado = 202;

            int Id = 1;

            var objSquad = new SquadInput()
            {
                Id_tribo = 5,
                Ativo = true,
                Nome = "Testando"
            };

            var actionResult = _squadController.Put(Id, objSquad);

            var okObjectResult = (AcceptedResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

    }
}
