using System.Collections.Generic;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class PapelNegocio : IPapelNegocio
    {


        private readonly IPapelRepositorio _papelRepositorio;

        public PapelNegocio(IPapelRepositorio _papelRepositorio)
        {
            this._papelRepositorio = _papelRepositorio;
        }

        public IEnumerable<PapelDto> Selecionar()
        {
            return _papelRepositorio.Selecionar();
        }
    }
}
