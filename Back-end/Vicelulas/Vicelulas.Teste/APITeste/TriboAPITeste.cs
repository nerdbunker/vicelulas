using Xunit;
using Vicelulas.Api.Controllers;
using Viceluas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;

namespace Vicelulas.Teste.APITeste
{
    public class TriboApiTeste
    {

        [Fact]
        public void RetornaStatusOKGetAll()
        {

            int valorEsperado = 200;

            var actionResult = _triboController.Get();

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }


        [Fact]
        public void RetornaStatusOKGetId()
        {
   
            int id = 1;
            int valorEsperado = 200;

            var actionResult = _triboController.GetId(id);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {

            int id = 0;

            Assert.Throws<NaoEncontradoException>(() => _triboController.GetId(id));
        }

        [Fact]
        public void RetornaStatusOKGetName()
        {

            var nome = "a";
            int valorEsperado = 200;

            var actionResult = _triboController.GetName(nome);

            var okObjectResult = (OkObjectResult)actionResult;

            Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        }

        [Fact]
        public void RetornaStatusOKPost()
        {
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
