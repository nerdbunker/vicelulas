using System;
using System.Collections.Generic;
using System.Text;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class PapelNegocio
    {
        private readonly PapelRepositorio _papelRepositorio;

        public PapelNegocio()
        {
            _papelRepositorio = new PapelRepositorio();
        }

        public IEnumerable<PapelDto> Selecionar()
        {
            return _papelRepositorio.Selecionar();
        }
    }
}
