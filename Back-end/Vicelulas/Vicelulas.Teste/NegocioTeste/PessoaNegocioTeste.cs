using Xunit;
using Vicelulas.Negocio;
using Vicelulas.Dominio.Exceções;
using Moq;
using Vicelulas.Dominio.Dto;
using System.Collections.Generic;
using Vicelulas.Dado;

namespace Vicelulas.Teste.NegocioTeste
{
    public class PessoaNegocioTeste
    {

   
        //[Fact]
        //public void RetornaStatusOkGetAll()
        //{
        //    var mockDependency = new Mock<IPessoaNegocio>();
        //    mockDependency.Setup(x => x.Selecionar()).Returns();

        //    Assert.NotEmpty(_pessoaNegocio.Selecionar());
        //}

        //[Fact]
        //public void RetornaStatusOkGetId()
        //{

        //    var atual = _pessoaNegocio.SelecionarPorId(1);
        //    Assert.Equal(1, atual.Id);
        //}

        //[Fact]
        //public void RetornaStatusNotFoundGetId()
        //{
        //    int id = 0;
        //    Assert.Throws<NaoEncontradoException>(() => _pessoaNegocio.SelecionarPorId(id));
        //}

        //[Fact]
        //public void RetornaStatusOkGetNome()
        //{
        //    var atual = _pessoaNegocio.SelecionarPorNome("Pablo Zampa");
        //    Assert.Single(atual);
        //}

        //[Fact]
        //public void RetornaStatusNotFoundGetNome()
        //{
        //    Assert.NotEmpty(_pessoaNegocio.SelecionarPorNome(""));
        //}

        //[Fact]
        //public void RetornaStatusOkGetIdSquad()
        //{
        //    Assert.NotEmpty(_pessoaNegocio.SelecionarPorIdSquad(1));
     
        //}

        //[Fact]
        //public void RetornaStatusNotFoundGetIdSquad()
        //{  
        //    int id = 0;
        //    Assert.Empty(_pessoaNegocio.SelecionarPorIdSquad(id));

        //}

    }
}
