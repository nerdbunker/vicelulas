using Xunit;
using Vicelulas.Negocio;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Dominio;
using Moq;
using Vicelulas.Dado;
using Vicelulas.DBMock;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Teste.NegocioTeste
{
    public class TriboNegocioTeste
    {
        [Fact]
        public void ListaDeTriboOK()
        {
            // Arrange
            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.Selecionar()).Returns(DbMock.Tribo);

            var _triboNegocio = new TriboNegocio(repoMock.Object);

            // Act
            var objRetornado = _triboNegocio.Selecionar();

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(DbMock.Tribo, objRetornado);
        }

        [Fact]
        public void TriboPorIdOk()
        {
            // Arrange
            var tribo = new TriboDto
            {
                Id = 1,
                NomeTribo = "Formacao",
                NomeMentor = "Anderson",
                IdMentor = 1,
                Ativo = true
            };
            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.SelecionarPorId(tribo.Id)).Returns(tribo);

            var _triboNegocio = new TriboNegocio(repoMock.Object);

            // Act
            var objRetornado = _triboNegocio.SelecionarPorId(tribo.Id);

            // Assert
            Assert.NotNull(objRetornado);
            Assert.Same(tribo, objRetornado);
        }

        [Fact]
        public void TriboPorIdNotFound()
        {
            // Arrange
            int id = 0;

            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.SelecionarPorId(0));
            var _triboNegocio = new TriboNegocio(repoMock.Object);

            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void TriboPorNomeOK()
        {
            // Arrange
            var nome = "NerdBunker";

            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome)).Returns(DbMock.Tribo);


            var _triboNegocio = new TriboNegocio(repoMock.Object);

            // Act
            var objRetornado = _triboNegocio.SelecionarPorNome(nome);

            // Assert
            Assert.NotNull(objRetornado);
        }

        [Fact]
        public void TriboPorNomeNulo()
        {
            // Arrange
            var tribo = new Tribo
            {
                Id = 0,
                Id_Mentor = 0,
                Nome = null,
                Ativo = false
            };

            var repoMock = new Mock<ITriboRepositorio>();

            var TriboNull = new TriboNegocio(repoMock.Object);

            // Assert
            Assert.Throws<ConflitoException>(() => TriboNull.Inserir(tribo));
        }

        [Fact]
        public void TriboPorNomeNotFound()
        {
            // Arrange
            var nome = "";

            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.SelecionarPorNome(nome));


            var _triboNegocio = new TriboNegocio(repoMock.Object);

            // Assert
            // Act + Assert
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.SelecionarPorNome(nome));
        }

        [Fact]
        public void TriboInserirOk()
        {
            // Arrange
            var tribo = new Tribo
            {
                Id = 10,
                Id_Mentor = 1,
                Nome = "Teste",
                Ativo = true
            };

            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.Inserir(tribo)).Returns(tribo.Id);

            var _triboNegocio = new TriboNegocio(repoMock.Object);

            //Act
            var objRetornado = _triboNegocio.Inserir(tribo);

            // Assert
            Assert.Equal(tribo.Id, objRetornado);
        }

        [Fact]
        public void TriboInserirNomeNullOrEmpty()
        {
            // Arrange
            var tribo = new Tribo
            {
                Id = 10,
                Id_Mentor = 1,
                Nome = "",
                Ativo = true
            };

            var repoMock = new Mock<ITriboRepositorio>();
            repoMock.Setup(m => m.Inserir(tribo));

            var _triboNegocio = new TriboNegocio(repoMock.Object);

            //Assert
            Assert.Throws<ConflitoException>(() => _triboNegocio.Inserir(tribo));
        }


    }
}