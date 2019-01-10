using Xunit;
using Vicelulas.Negocio;
using Vicelulas.Dominio.Exceções;
using Moq;
using Vicelulas.Dominio.Dto;
using System.Collections.Generic;
using Vicelulas.Dado;
using Vicelulas.DBMock;
using Vicelulas.Dominio;
using System;
using System.Linq.Expressions;

namespace Vicelulas.Teste.NegocioTeste
{
    public class PessoaNegocioTeste
    {
        [Fact]
        public void ListaDePessoaOK()
        {
            // Arrange
            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Pessoa);
            var repoMock2 = new Mock<IMentorRepositorio>();
            repoMock2.Setup(m => m.Selecionar()).Returns(DbMock.Mentor);

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Act
            var objRetornado = _pessoaNegocio.Selecionar();

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Pessoa, objRetornado);
        }

        [Fact]
        public void PessoaPorIdOk()
        {
            // Arrange
            var pessoa = new PessoaDto
            {
                Id = 1,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.SelecionarPorId(pessoa.Id)).Returns(pessoa);
            var repoMock2 = new Mock<IMentorRepositorio>();

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Act
            var objRetornado = _pessoaNegocio.SelecionarPorId(pessoa.Id);

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(pessoa, objRetornado);
        }

        [Fact]
        public void PessoaPorIdNotFound()
        {
            // Arrange
            int id = 0;

            var repoMock = new Mock<IPessoaRepositorio>();
            var repoMock2 = new Mock<IMentorRepositorio>();

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _pessoaNegocio.SelecionarPorId(id));
        }


        [Fact]
        public void PessoaPorNomeOK()
        {
            // Arrange
            var nome = "Pedro Aviador";

            var repoMock = new Mock<IPessoaRepositorio>();
            var repoMock2 = new Mock<IMentorRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome)).Returns(DbMock.Pessoa);

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Act
            var objRetornado = _pessoaNegocio.SelecionarPorNome(nome);

            // Assert
            Assert.NotNull(objRetornado);
        }

        [Fact]
        public void PessoaPorNomeNulo()
        {
            // Arrange
            var pessoa = new PessoaDto
            {
                Nome = null,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(pessoa.Nome));
            var repoMock2 = new Mock<IMentorRepositorio>();

            var pessoaNull = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Assert
            Assert.Throws<NaoEncontradoException>(() => pessoaNull.SelecionarPorNome(pessoa.Nome));
        }

        [Fact]
        public void PessoaPorNomeNotFound()
        {
            // Arrange
            var nome = "";

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome));
            var repoMock2 = new Mock<IMentorRepositorio>();


            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Assert
            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _pessoaNegocio.SelecionarPorNome(nome));
        }

        [Fact]
        public void PessoaPorIdSquadOK()
        {
            // Arrange
            var id = 1;

            var repoMock = new Mock<IPessoaRepositorio>();
            var repoMock2 = new Mock<IMentorRepositorio>();
            repoMock.Setup(m => m.SelecionarPorIdSquad(id)).Returns(DbMock.Pessoa);

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Act
            var objRetornado = _pessoaNegocio.SelecionarPorIdSquad(id);

            // Assert
            Assert.NotNull(objRetornado);
        }

        [Fact]
        public void PessoaPorIdSquadNulo()
        {
            // Arrange
            var pessoa = new PessoaDto
            {
                Id_Squads = 0,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.SelecionarPorIdSquad(pessoa.Id_Squads));
            var repoMock2 = new Mock<IMentorRepositorio>();

            var pessoaNull = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            // Assert
            Assert.Throws<NaoEncontradoException>(() => pessoaNull.SelecionarPorIdSquad(pessoa.Id_Squads));
        }

        [Fact]
        public void PessoaInserirOk()
        {
            // Arrange
            var pessoa = new Pessoa
            {
                Id = 1,
                Id_papel = 1,
                Nome = "Pedro Aviador",
                Senha = "123Aa321",
                Email = "Pedro@viceri.com",
                Ativo = true,
                Id_squad = 1,
                Id_unidade = 1,
                Permissao = 1,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.Inserir(pessoa)).Returns(pessoa.Id);
            var repoMock2 = new Mock<IMentorRepositorio>();

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            //Act
            var objRetornado = _pessoaNegocio.Inserir(pessoa);

            // Assert
            Assert.Equal(pessoa.Id, objRetornado);
        }

        [Fact]
        public void PessoaInserirNomeNullOrEmpty()
        {
            // Arrange
            var pessoa = new Pessoa
            {
                Nome = null,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            repoMock.Setup(m => m.Inserir(pessoa));
            var repoMock2 = new Mock<IMentorRepositorio>();

            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);

            //Assert
            Assert.Throws<ConflitoException>(() => _pessoaNegocio.Inserir(pessoa));
        }

        [Fact]
        public void PessoaAtivarDesativarOk()
        {
            // Arrange
            var pessoa = new Pessoa
            {
                Id = 1,
                Ativo = true,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            var repoMock2 = new Mock<IMentorRepositorio>();
            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);
            repoMock.Setup(mr => mr.AtivarDesativarPessoa(pessoa.Id, !pessoa.Ativo)).Callback((int Id, bool Ativo) =>
            {
                var objRetornado = _pessoaNegocio.SelecionarPorId(pessoa.Id);
            }).Verifiable();

            // Assert
            //repoMock.Verify(mr => mr.AtivarDesativarPessoa(It.IsAny<int>(), It.IsAny<bool>()), Times.Once());
        }

        [Fact]
        public void PessoaAtivarDesativarNotFound()
        {
            // Arrange
            var pessoa = new Pessoa
            {
                Id = 0,
                Ativo = true,
            };

            var repoMock = new Mock<IPessoaRepositorio>();
            var repoMock2 = new Mock<IMentorRepositorio>();
            var _pessoaNegocio = new PessoaNegocio(repoMock.Object, repoMock2.Object);
            repoMock.Setup(mr => mr.AtivarDesativarPessoa(pessoa.Id, !pessoa.Ativo));

            // Assert
            Assert.Throws<NaoEncontradoException>(() => _pessoaNegocio.AtivarDesativarPessoa(pessoa.Id));
        }
    }
}
