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

namespace Vicelulas.Teste.NegocioTeste
{
    public class UnidadeNegocioTeste
    {
        [Fact]
        public void ListaDeUnidadeOK()
        {
            // Arrange
            var repoMock = new Mock<IUnidadeRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Unidade);

            var _unidadeNegocio = new UnidadeNegocio(repoMock.Object);

            // Act
            var objRetornado = _unidadeNegocio.Selecionar();

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Unidade, objRetornado);
        }
    }
}
