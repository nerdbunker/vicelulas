using Xunit;
using Vicelulas.Negocio;
using Vicelulas.Dominio.Exceções;
using Moq;
using Vicelulas.DBMock;
using System.Collections.Generic;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dado;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace Vicelulas.Teste.NegocioTeste
{
    public class SquadNegocioTeste
    {

        [Fact]
        public void ListaDeSquadOK()
        {
            // Arrange
            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Squad);
      
            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act
            var objRetornado = _squadNegocio.Selecionar();
    
            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Squad, objRetornado);

        }

        [Fact]
        public void SquadPorIdOk()
        {
            // Arrange
            var squad = new SquadDto
            {
                Id = 1,
                Id_Tribo = 1,
                Nome = "NerdBunker",
                NomeTribo = "Formacao",
                Ativo = true
            };
            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorId(squad.Id)).Returns(squad);

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act
            var objRetornado = _squadNegocio.SelecionarPorId(squad.Id);

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(squad, objRetornado);
        }

        [Fact]
        public void SquadPorIdNotFound()
        {
            // Arrange
            int id = 0;

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorId(0));
            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _squadNegocio.SelecionarPorId(id));
        }


        [Fact]
        public void SquadPorNomeOK()
        {
            // Arrange
            var nome = "Nerd";

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome)).Returns(DbMock.Squad);


            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act
            var objRetornado = _squadNegocio.SelecionarPorNome(nome);

            // Assert
            Assert.NotNull(objRetornado);

            
        }

        [Fact]
        public void SquadPorNomeNotFound()
        {
            // Arrange
            var nome = "";

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome));


            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Assert
            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _squadNegocio.SelecionarPorNome(nome));


        }

        [Fact]
        public void SquadPorIdTriboOK()
        {
            // Arrange
            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorIdTribo(1)).Returns(DbMock.Squad);

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act
            var objRetornado = _squadNegocio.SelecionarPorIdTribo(1);

            // Assert
            Assert.NotNull(objRetornado);
        }

        [Fact]
        public void SquadPorIdTriboNotFound()
        {

            // Arrange
            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarPorIdTribo(0));

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _squadNegocio.SelecionarPorIdTribo(0));
        }

     

    }
}
