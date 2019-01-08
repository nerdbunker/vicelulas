using Xunit;
using Vicelulas.Api.Controllers;
using Vicelulas.Dominio.Exceções;
using Microsoft.AspNetCore.Mvc;
using Vicelulas.Api.Model;
using Vicelulas.Negocio;
using Moq;
using Vicelulas.DBMock;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Teste.APITeste
{
    public class SquadApiTeste
    {


        //[Fact]
        //public void RetornaStatusOKGetAll()
        //{

<<<<<<< HEAD
        //    int valorEsperado = 200;

        //    var actionResult = _squadController.Get();

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        //}
=======
            // Arrange
            int valorEsperado = 200;

            var repoMock = new Mock<ISquadNegocio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Squad);
            var _squadController = new SquadController(repoMock.Object);

            // Act
            var actionResult = _squadController.Get();
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
        }
>>>>>>> 173964ed076d1b5621ba0084e9b9da3c6e06db45

        //[Fact]
        //public void RetornaStatusOKGetId()
        //{

<<<<<<< HEAD
        //    int id = 1;
        //    int valorEsperado = 200;

        //    var actionResult = _squadController.GetId(id);

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);
=======
            // Arrange
            int valorEsperado = 200;

            var squad = new SquadDto
            {
                Id = 1,
                Id_Tribo = 1,
                Nome = "NerdBunker",
                NomeTribo = "Formacao",
                Ativo = true
            };
            var repoMock = new Mock<ISquadNegocio>();
            repoMock.Setup(m => m.SelecionarPorId(squad.Id)).Returns(squad);
            var _squadController = new SquadController(repoMock.Object);


            // Act
            var actionResult = _squadController.GetId(squad.Id);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
>>>>>>> 173964ed076d1b5621ba0084e9b9da3c6e06db45

        //}

<<<<<<< HEAD
        //[Fact]
        //public void RetornaStatusNotFoundGetId()
        //{

        //    int id = 0;

        //    Assert.Throws<NaoEncontradoException>(() => _squadController.GetId(id));
        //}

        //[Fact]
        //public void RetornaStatusOKGetName()
        //{

        //    var nome = "a";
        //    int valorEsperado = 200;

        //    var actionResult = _squadController.GetName(nome);

        //    var okObjectResult = (OkObjectResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);
=======
  
        [Fact]
        public void RetornaStatusOKGetName()
        {
            // Arrange
            var nome = "NerdBunker";
            int valorEsperado = 200;

            var repoMock = new Mock<ISquadNegocio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome)).Returns(DbMock.Squad);
            var _squadController = new SquadController(repoMock.Object);

            // Act
            var actionResult = _squadController.GetName(nome);
            var okObjectResult = (OkObjectResult)actionResult;

            // Assert
            Assert.Equal(valorEsperado, okObjectResult.StatusCode);
>>>>>>> 173964ed076d1b5621ba0084e9b9da3c6e06db45

        //}

        //[Fact]
        //public void RetornaStatusOKPost()
        //{
<<<<<<< HEAD
  
        //    int valorEsperado = 201;

        //    var objSquad = new SquadInput()
        //    {
        //        Id_tribo = 5,
        //        Nome = "Teste26",
        //        Ativo = true
        //    };

        //    var actionResult = _squadController.Post(objSquad);

        //    var okObjectResult = (CreatedAtRouteResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusOKPut()
        //{
        //    int valorEsperado = 202;

        //    int Id = 1;

        //    var objSquad = new SquadInput()
        //    {
        //        Id_tribo = 5,
        //        Ativo = true,
        //        Nome = "Testando"
        //    };

        //    var actionResult = _squadController.Put(Id, objSquad);

        //    var okObjectResult = (AcceptedResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}
=======

        //    int valorEsperado = 201;

        //    var objSquad = new SquadInput()
        //    {
        //        Id_tribo = 5,
        //        Nome = "Teste26",
        //        Ativo = true
        //    };

        //    var actionResult = _squadController.Post(objSquad);

        //    var okObjectResult = (CreatedAtRouteResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusOKPut()
        //{
        //    int valorEsperado = 202;

        //    int Id = 1;

        //    var objSquad = new SquadInput()
        //    {
        //        Id_tribo = 5,
        //        Ativo = true,
        //        Nome = "Testando"
        //    };

        //    var actionResult = _squadController.Put(Id, objSquad);

        //    var okObjectResult = (AcceptedResult)actionResult;

        //    Assert.Equal(valorEsperado, okObjectResult.StatusCode);

        //}

        //[Fact]
        //public void RetornaStatusNotFoundGetId()
        //{

        //    Mock
        //    var squad = new SquadDto();

        //    var repoMock = new Mock<ISquadNegocio>();
        //    repoMock.Setup(m => m.SelecionarPorId(0)).Returns(squad);
        //    var _squadController = new SquadController(repoMock.Object);



        //    Controller Action
        //    Assert.Throws<NaoEncontradoException>(() => _squadController.GetId(0));
        //}

>>>>>>> 173964ed076d1b5621ba0084e9b9da3c6e06db45

    }
}
