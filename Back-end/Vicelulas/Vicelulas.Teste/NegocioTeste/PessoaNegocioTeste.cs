using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;

namespace Vicelulas.Teste.NegocioTeste
{
    public class PessoaNegocioTeste
    {
        private readonly IPessoaNegocio _pessoaNegocio;

        public PessoaNegocioTeste(IPessoaNegocio _pessoaNegocio)
        {
            this._pessoaNegocio = _pessoaNegocio;
        }


        [Fact]
        public void RetornaStatusOkGetAll()
        {

            Assert.NotEmpty(_pessoaNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {

            var atual = _pessoaNegocio.SelecionarPorId(1);
            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => _pessoaNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {
            var atual = _pessoaNegocio.SelecionarPorNome("Pablo Zampa");
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            Assert.NotEmpty(_pessoaNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkGetIdSquad()
        {
            Assert.NotEmpty(_pessoaNegocio.SelecionarPorIdSquad(1));
     
        }

        [Fact]
        public void RetornaStatusNotFoundGetIdSquad()
        {  
            int id = 0;
            Assert.Empty(_pessoaNegocio.SelecionarPorIdSquad(id));

        }

    }
}
