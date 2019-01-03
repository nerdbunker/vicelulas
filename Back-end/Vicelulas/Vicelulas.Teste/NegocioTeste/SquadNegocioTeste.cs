using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;

namespace Vicelulas.Teste.NegocioTeste
{
    public class SquadNegocioTeste
    {
        private readonly ISquadNegocio _squadNegocio;

        public SquadNegocioTeste(ISquadNegocio _squadNegocio)
        {
            this._squadNegocio = _squadNegocio;
        }

        [Fact]
        public void RetornaStatusOkGetAll()
        {
            Assert.NotEmpty(_squadNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {
            var atual = _squadNegocio.SelecionarPorId(1);
            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => _squadNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {  
            var atual = _squadNegocio.SelecionarPorNome("Consultoria");
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            Assert.NotEmpty(_squadNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkGetIdTribo()
        {
            var atual = _squadNegocio.SelecionarPorIdTribo(1);
            Assert.NotNull(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetIdTribo()
        {
            var atual = _squadNegocio.SelecionarPorIdTribo(0);
            Assert.NotNull(atual);
        }

    }
}
