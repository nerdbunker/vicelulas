using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vicelulas.Negocio;
using Viceluas.Dominio.Dto;


namespace Vicelulas.Teste.APITeste
{
    public class TriboNegocioTeste
    {
        [Fact]
        public void Teste()
        {
            TriboNegocio _triboNegocio = new TriboNegocio();
            TriboDto _triboDto = new TriboDto();
            TriboDto _triboDtoEsperado = new TriboDto();
            _triboDto = _triboNegocio.SelecionarPorId(1);

            Assert.Equal(_triboDtoEsperado, _triboDto);

        }
    }
}
