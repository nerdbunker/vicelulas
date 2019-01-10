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
using Vicelulas.Dominio.Seguranca;

namespace Vicelulas.Teste.NegocioTeste
{
    public class AutenticacaoNegocioTeste
    {
        [Fact]
        public void EntrarOk()
        {
            // Arrange
            var username = "Pedro@viceri.com";
            var senha = "123Aa321";
            var hash = PasswordHash.Create(senha);

            var repoMock = new Mock<IAutenticacaoRepositorio>();
            repoMock.Setup(m => m.Entrar(username, senha)).Returns(DbMock.Pessoa[0]);

            var _autenticacaoNegocio = new AutenticacaoNegocio(repoMock.Object);

            // Act
            var objRetornado = _autenticacaoNegocio.Entrar(username, senha);

            // Assert
            Assert.NotNull(objRetornado);
        }

        [Fact]
        public void AutenticacaoEmptyOrNull()
        {
            // Arrange
            var username = "";
            var password = "";

            var repoMock = new Mock<IAutenticacaoRepositorio>();
            repoMock.Setup(m => m.Entrar(username, password)).Returns(DbMock.Pessoa[0]);

            var _autenticacaoNegocio = new AutenticacaoNegocio(repoMock.Object);

            // Assert
            Assert.Throws<NaoEncontradoException>(() => _autenticacaoNegocio.Entrar(username, password));
        }

        [Fact]
        public void AutenticacaoInativa()
        {
            // Arrange
            var pessoa = new PessoaDto
            {
                Id = 1,
                Id_Papel = 1,
                Nome = "teste",
                Email = "teste@viceri.com",
                Cargo = "Estagiario",
                Ativo = false,
                Id_Squads = 1,
                Id_Tribo = 1,
                Id_Unidade = 1,
                Permissao = 1,
                SquadNome = "teste",
                TriboNome = "Formacao",
                Unidade = "General Osorio"
            };

            var password = "123Aa321";

            var repoMock = new Mock<IAutenticacaoRepositorio>();
            repoMock.Setup(m => m.Entrar(pessoa.Email, password)).Returns(pessoa);

            var _autenticacaoNegocio = new AutenticacaoNegocio(repoMock.Object);

            // Act
            var objRetornado = _autenticacaoNegocio.Entrar(pessoa.Email, password);

            // Assert
            Assert.Throws<RecusadoException>(() => _autenticacaoNegocio.Entrar(pessoa.Email, password));
        }

    }
}
