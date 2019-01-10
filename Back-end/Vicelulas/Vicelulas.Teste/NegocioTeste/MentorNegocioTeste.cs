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
    public class MentorNegocioTeste
    {
        [Fact]
        public void ListaDeMentorOK()
        {
            // Arrange
            var repoMock = new Mock<IMentorRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Mentor);

            var _mentorNegocio = new MentorNegocio(repoMock.Object);

            // Act
            var objRetornado = _mentorNegocio.Selecionar();

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Mentor, objRetornado);
        }
    }
}
