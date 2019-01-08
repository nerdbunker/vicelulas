using Xunit;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Api.Model;
using Moq;
using Vicelulas.Negocio;

namespace Vicelulas.Teste.APITeste
{
    public class PessoaControllerTeste
    {

        //[Fact]
        //public void RetornaStatusOKGetAll()
        //{
           

        //    int valorEsperado = 200;

        //    var actionResult = _pessoaController.Get();

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        //}

        //[Fact]
        //public void RetornaStatusOKGetId()
        //{

        //    int id = 1;
        //    int valorEsperado = 200;

        //    var actionResult = _pessoaController.GetId(id);

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusNotFoundGetId()
        //{ 

        //    int id = 0;

        //    Assert.Throws<NaoEncontradoException>(() => _pessoaController.GetId(id));
        //}

        //[Fact]
        //public void RetornaStatusOKGetIdSquad()
        //{
  
        //    int id = 1;
        //    int valorEsperado = 200;

        //    var actionResult = _pessoaController.GetIdSquad(id);

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusOKGetName()
        //{

        //    var nome = "a";
        //    int valorEsperado = 200;

        //    var actionResult = _pessoaController.GetName(nome);

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusOKPut()
        //{
        //    int valorEsperado = 202;

        //    int Id = 1;

        //    var objPessoa = new PessoaInput()
        //    {
        //        Id_squads = 1,
        //        Id_papel = 5,
        //        Id_unidade = 1,
        //        Nome = "Testando",
        //        Email = "teste@teste",
               
        //    };

        //    var actionResult = _pessoaController.Put(Id, objPessoa);

        //    var okObjectResult = (AcceptedResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}
    }
}
