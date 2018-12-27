using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;

namespace Vicelulas.Teste.NegocioTeste
{
    public class PessoaNegocioTeste
    {
        [Fact]
        public void RetornaStatusOkGetAll()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            Assert.NotEmpty(pessoaNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            var atual = pessoaNegocio.SelecionarPorId(1);

            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => pessoaNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            var atual = pessoaNegocio.SelecionarPorNome("Pablo Zampa");
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            Assert.NotEmpty(pessoaNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkGetIdSquad()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            Assert.NotEmpty(pessoaNegocio.SelecionarPorIdSquad(1));
            
        }

        [Fact]
        public void RetornaStatusNotFoundGetIdSquad()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();
            int id = 0;
            Assert.Empty(pessoaNegocio.SelecionarPorIdSquad(id));

        }

    }
}
