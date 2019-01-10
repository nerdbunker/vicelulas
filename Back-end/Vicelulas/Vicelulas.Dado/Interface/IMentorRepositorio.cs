using System.Collections.Generic;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public interface IMentorRepositorio
    {
        int Inserir(int entity);
        IEnumerable<MentorDto> Selecionar();
    }
}