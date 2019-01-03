using System.Collections.Generic;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class UnidadeNegocio : IUnidadeNegocio
    {
        private readonly IUnidadeRepositorio _UnidadeRepositorio;

        public UnidadeNegocio(IUnidadeRepositorio _UnidadeRepositorio)
        {
            this._UnidadeRepositorio = _UnidadeRepositorio;
        }

        public IEnumerable<UnidadeDto> Selecionar()
        {
            return _UnidadeRepositorio.Selecionar();
        }
    }
}
