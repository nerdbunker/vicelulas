using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;

namespace Vicelulas.Teste.NegocioTeste
{
    public class TriboNegocioTeste
    {
        [Fact]
        public void RetornaStatusOkGetAll()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Assert.NotEmpty(triboNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            var atual = triboNegocio.SelecionarPorId(1);

            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => triboNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            var atual = triboNegocio.SelecionarPorNome("Viceri");
            var esperado = triboNegocio.SelecionarPorId(7);
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Assert.NotEmpty(triboNegocio.SelecionarPorNome(""));
        }


    }
}