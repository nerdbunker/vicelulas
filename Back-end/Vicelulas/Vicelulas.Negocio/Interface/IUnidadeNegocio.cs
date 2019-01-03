using System.Collections.Generic;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public interface IUnidadeNegocio
    {
        IEnumerable<UnidadeDto> Selecionar();
    }
}