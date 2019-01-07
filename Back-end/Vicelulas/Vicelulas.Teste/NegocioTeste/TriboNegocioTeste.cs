using Xunit;
using Vicelulas.Negocio;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Dominio;
using Moq;

namespace Vicelulas.Teste.NegocioTeste
{
    public class TriboNegocioTeste
    {
        private readonly ITriboNegocio _triboNegocio;

        public TriboNegocioTeste(ITriboNegocio _triboNegocio)
        {
            this._triboNegocio = _triboNegocio;
        }

        [Fact]
        public void RetornaStatusOkGetAll()
        {
           
            Assert.NotEmpty(_triboNegocio.Selecionar());
        }

        [Fact]
        public void RetornaStatusOkGetId()
        {

            var atual = _triboNegocio.SelecionarPorId(1);

            Assert.Equal(1, atual.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundGetId()
        {  
            int id = 0;
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.SelecionarPorId(id));
        }

        [Fact]
        public void RetornaStatusOkGetNome()
        {
            var atual = _triboNegocio.SelecionarPorNome("Viceri");
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            Assert.NotEmpty(_triboNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkInserir()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "gfgdggdf",
                Ativo = true
            };

            var valor = _triboNegocio.Inserir(tribo);
            Assert.Equal(21, valor);
        }

        [Fact]
        public void RetornaStatusConflitoInserir()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "Consultoria",
                Ativo = true
            };

            Assert.Throws<ConflitoException>(() => _triboNegocio.Inserir(tribo));
        }

        [Fact]
        public void RetornaStatusNullInserir()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "",
                Ativo = true
            };
            Assert.Throws<ConflitoException>(() => _triboNegocio.Inserir(tribo));
        }

        [Fact]
        public void RetornaStatusOkAlterar()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "Testefdfdfd",
                Ativo = true
            };
            var valor = _triboNegocio.Alterar(2, tribo);
            Assert.Equal(tribo.Nome, valor.Nome);
        }

        [Fact]
        public void RetornaStatusNotFoundAlterar()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "Teste2",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.Alterar(0, tribo));
        }

        [Fact]
        public void RetornaStatusConflitoAlterar()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "Consultoria",
                Ativo = true
            };
            Assert.Throws<ConflitoException>(() => _triboNegocio.Alterar(9, tribo));
        }

        [Fact]
        public void RetornaStatusOkDesativar()
        {
            Tribo tribo = new Tribo()
            {
                Id = 7,
                Nome = "Viceri",
                Ativo = true
            };
            var valor = _triboNegocio.Desativar(7, tribo);
            Assert.Equal(tribo.Id, valor.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundDesativarId()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "TesteDel",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.Desativar(0, tribo));
        }

        [Fact]
        public void RetornaStatusNotFoundDesativarNome()
        {
            Tribo tribo = new Tribo()
            {
                Nome = "TesteDel",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => _triboNegocio.Desativar(3, tribo));
        }

    }
}