using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dominio;

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
            Assert.Single(atual);
        }

        [Fact]
        public void RetornaStatusNotFoundGetNome()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Assert.NotEmpty(triboNegocio.SelecionarPorNome(""));
        }

        [Fact]
        public void RetornaStatusOkInserir()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "gfgdggdf",
                Ativo = true
            };

            var valor = triboNegocio.Inserir(tribo);
            Assert.Equal(21, valor);
        }

        [Fact]
        public void RetornaStatusConflitoInserir()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "Consultoria",
                Ativo = true
            };

            Assert.Throws<ConflitoException>(() => triboNegocio.Inserir(tribo));
        }

        [Fact]
        public void RetornaStatusNullInserir()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "",
                Ativo = true
            };
            Assert.Throws<ConflitoException>(() => triboNegocio.Inserir(tribo));
        }

        [Fact]
        public void RetornaStatusOkAlterar()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "Testefdfdfd",
                Ativo = true
            };
            var valor = triboNegocio.Alterar(2, tribo);
            Assert.Equal(tribo.Nome, valor.Nome);
        }

        [Fact]
        public void RetornaStatusNotFoundAlterar()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "Teste2",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => triboNegocio.Alterar(0, tribo));
        }

        [Fact]
        public void RetornaStatusConflitoAlterar()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "Consultoria",
                Ativo = true
            };
            Assert.Throws<ConflitoException>(() => triboNegocio.Alterar(9, tribo));
        }

        [Fact]
        public void RetornaStatusOkDesativar()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Id = 7,
                Nome = "Viceri",
                Ativo = true
            };
            var valor = triboNegocio.Desativar(7, tribo);
            Assert.Equal(tribo.Id, valor.Id);
        }

        [Fact]
        public void RetornaStatusNotFoundDesativarId()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "TesteDel",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => triboNegocio.Desativar(0, tribo));
        }

        [Fact]
        public void RetornaStatusNotFoundDesativarNome()
        {
            TriboNegocio triboNegocio = new TriboNegocio();
            Tribo tribo = new Tribo()
            {
                Nome = "TesteDel",
                Ativo = true
            };
            Assert.Throws<NaoEncontradoException>(() => triboNegocio.Desativar(3, tribo));
        }

    }
}