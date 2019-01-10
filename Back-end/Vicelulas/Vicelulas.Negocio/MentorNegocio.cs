using System;
using System.Collections.Generic;
using System.Text;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class MentorNegocio : IMentorNegocio
    {
        private readonly IMentorRepositorio _mentorRepositorio;

        public MentorNegocio(IMentorRepositorio _mentorRepositorio)
        {
            this._mentorRepositorio = _mentorRepositorio;
        }

        public IEnumerable<MentorDto> Selecionar()
        {
            return _mentorRepositorio.Selecionar();
        }
    }
}
