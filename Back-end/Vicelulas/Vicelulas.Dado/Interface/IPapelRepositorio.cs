using System.Collections.Generic;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public interface IPapelRepositorio
    {
        IEnumerable<PapelDto> Selecionar();
    }
}