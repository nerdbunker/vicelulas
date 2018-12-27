using System.Collections.Generic;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class UnidadeNegocio
    {
        private readonly UnidadeRepositorio _UnidadeRepositorio;

        public UnidadeNegocio()
        {
            _UnidadeRepositorio = new UnidadeRepositorio();
        }

        public IEnumerable<UnidadeDto> Selecionar()
        {
            return _UnidadeRepositorio.Selecionar();
        }
    }
}
