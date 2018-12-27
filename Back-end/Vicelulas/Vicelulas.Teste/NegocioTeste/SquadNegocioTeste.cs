using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;

namespace Vicelulas.Teste.NegocioTeste
{
    public class SquadNegocioTeste
    {
        [Fact]
        public void RetornaStatusOkGetAll()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            Assert.NotEmpty(squadNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            var atual = squadNegocio.SelecionarPorId(1);

            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => squadNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            var atual = squadNegocio.SelecionarPorNome("Consultoria");
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            Assert.NotEmpty(squadNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkGetIdTribo()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            var atual = squadNegocio.SelecionarPorIdTribo(1);
            Assert.NotNull(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetIdTribo()
        {
            SquadNegocio squadNegocio = new SquadNegocio();
            var atual = squadNegocio.SelecionarPorIdTribo(0);
            Assert.NotNull(atual);
        }

    }
}
