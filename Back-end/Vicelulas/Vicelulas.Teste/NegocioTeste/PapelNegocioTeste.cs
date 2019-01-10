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
    public class PapelNegocioTeste
    {
        [Fact]
        public void ListaDePapelOK()
        {
            // Arrange
            var repoMock = new Mock<IPapelRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Papel);

            var _papelNegocio = new PapelNegocio(repoMock.Object);

            // Act
            var objRetornado = _papelNegocio.Selecionar();

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Papel, objRetornado);
        }
    }
}
