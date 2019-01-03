using System.Collections.Generic;
using Viceluas.Dominio.Dto;
using Vicelulas.Dominio;

namespace Vicelulas.Negocio
{
    public interface ISquadNegocio
    {
        SquadDto Alterar(int Id, Squad entity);
        void AtivarDesativarSquad(int id);
        SquadDto Desativar(int Id, Squad entity);
        int Inserir(Squad entity);
        IEnumerable<SquadDto> Selecionar();
        SquadDto SelecionarPorId(int id);
        IEnumerable<SquadDto> SelecionarPorIdTribo(int id);
        IEnumerable<SquadDto> SelecionarPorNome(string nome);
    }
}