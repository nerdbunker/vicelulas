using System.Collections.Generic;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public interface IMentorNegocio
    {
        IEnumerable<MentorDto> Selecionar();
    }
}