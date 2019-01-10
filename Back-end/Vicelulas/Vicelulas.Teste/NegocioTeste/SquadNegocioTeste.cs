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
using Vicelulas.Dominio;
using Vicelulas.Api.Model;

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
        public void SquadPorNomeNulo()
        {
            // Arrange
            var squad = new Squad
            {
                Id = 0,
                Id_tribo = 0,
                Nome = null,
                Ativo = false
            };

            var repoMock = new Mock<ISquadRepositorio>();

            var SquadNull = new SquadNegocio(repoMock.Object);

            // Assert
            Assert.Throws<ConflitoException>(() => SquadNull.Inserir(squad));
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

        [Fact]
        public void SquadSemTriboOk()
        {
            // Arrange
            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.SelecionarSquadsSemTribo()).Returns(DbMock.Squad);

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            // Act
            var objRetornado = _squadNegocio.SelecionarSquadsSemTribo();

            // Assert
            Assert.Same(DbMock.Squad, objRetornado);
        }

        [Fact]
        public void SquadInserirOk()
        {
            // Arrange
            var squad = new Squad
            {
                Id = 1,
                Id_tribo = 1,
                Nome = "Teste",
                Ativo = true,
                Id_Mentor = 1,
            };

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.Inserir(squad)).Returns(squad.Id);

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            //Act
            var objRetornado = _squadNegocio.Inserir(squad);

            // Assert
            Assert.Equal(squad.Id, objRetornado);
        }

        [Fact]
        public void SquadInserirNomeNullOrEmpty()
        {
            // Arrange
            var squad = new Squad
            {
                Id = 1,
                Id_tribo = 1,
                Nome = null,
                Ativo = true
            };

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.Inserir(squad));

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            //Assert
            Assert.Throws<ConflitoException>(() => _squadNegocio.Inserir(squad));
        }

        [Fact]
        public void SquadInserirNomeExistente()
        {
            // Arrange
            var squad1 = new Squad
            {
                Id = 1,
                Id_tribo = 1,
                Nome = "Teste",
                Ativo = true
            };

            var squad2 = new Squad
            {
                Id = 2,
                Id_tribo = 2,
                Nome = "Teste",
                Ativo = true
            };

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.Inserir(squad1));
            repoMock.Setup(m => m.Inserir(squad2));

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            //Act
            _squadNegocio.Inserir(squad1);
            _squadNegocio.Inserir(squad2);

            //Assert
            Assert.Throws<ConflitoException>(() => _squadNegocio.Inserir(squad2));
        }

        [Fact]
        public void SquadAlterarOK()
        {
            // Arrange
            var squad = new Squad
            {
                Id = 1,
                Id_tribo = 1,
                Nome = "Teste",
                Ativo = true
            };

            var repoMock = new Mock<ISquadRepositorio>();
            repoMock.Setup(m => m.Alterar(squad));

            var _squadNegocio = new SquadNegocio(repoMock.Object);

            //Act
            var objRetornado = _squadNegocio.Alterar(squad.Id, squad);

            // Assert
            Assert.NotNull(objRetornado);
        }
    }
}
