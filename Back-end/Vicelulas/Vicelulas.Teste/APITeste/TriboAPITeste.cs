using Xunit;
using Vicelulas.Api.Controllers;
using Viceluas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Dominio;
using Vicelulas.Api.Model;

namespace Vicelulas.Teste.APITeste
{
    public class TriboApiTeste
    {
        [Fact]
        public void RetornaStatusOKGetAll()
        {
            TriboController _triboController = new TriboController();
            int valorEsperado = 200;

            var actionResult = _triboController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }


        [Fact]
        public void RetornaStatusOKGetId()
        {
            TriboController _triboController = new TriboController();
            int id = 1;
            int valorEsperado = 200;

            var actionResult = _triboController.GetId(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            TriboController _triboController = new TriboController();

            int id = 0;

            Assert.Throws<NaoEncontradoException>(() => _triboController.GetId(id));
        }

        [Fact]
        public void RetornaStatusOKGetName()
        {
            TriboController triboController = new TriboController();

            var nome = "a";
            int valorEsperado = 200;

            var actionResult = triboController.GetName(nome);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPost()
        {
            TriboController _triboController = new TriboController();
            int valorEsperado = 201;

            var objTribo = new TriboInput()
            {
                Nome = "Teste26",
                Ativo = true
            };

            var actionResult = _triboController.Post(objTribo);

            var okObjectResult = (CreatedAtRouteResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPut()
        {
            TriboController _triboController = new TriboController();
            int valorEsperado = 202;

            int Id = 1;
            
            var objTribo = new TriboInput()
            {
                
                Ativo = true,
                Nome = "Tentando"
            };

            var actionResult = _triboController.Put(Id, objTribo);

            var okObjectResult = (AcceptedResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }


    }
}
