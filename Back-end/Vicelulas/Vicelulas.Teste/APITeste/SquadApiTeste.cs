using Xunit;
using Vicelulas.Api.Controllers;
using Viceluas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;

namespace Vicelulas.Teste.APITeste
{
    public class SquadApiTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {
            SquadController squadController = new SquadController();
            int valorEsperado = 200;

            var actionResult = squadController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }

        [Fact]
        public void RetornaStatusOKGetId()
        {
            SquadController squadController = new SquadController();
            int id = 1;
            int valorEsperado = 200;

            var actionResult = squadController.GetId(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            SquadController squadController = new SquadController();

            int id = 0;

            Assert.Throws<NaoEncontradoException>(() => squadController.GetId(id));
        }

        [Fact]
        public void RetornaStatusOKGetName()
        {
            SquadController squadController = new SquadController();

            var nome = "a";
            int valorEsperado = 200;

            var actionResult = squadController.GetName(nome);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPost()
        {
            SquadController _squadController = new SquadController();
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
            SquadController _squadController = new SquadController();
            int valorEsperado = 202;

            int Id = 1004;

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
