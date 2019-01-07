using System.Collections.Generic;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dominio;

namespace Vicelulas.Dado
{
    public interface ISquadRepositorio
    {
        void Alterar(Squad entity);
        void AlterarStatus(Squad entity);
        void AtivarDesativarSquad(int id, bool ativo);
        int Inserir(Squad entity);
        IEnumerable<SquadDto> Selecionar();
        SquadDto SelecionarPorId(int id);
        IEnumerable<SquadDto> SelecionarPorIdTribo(int id);
        IEnumerable<SquadDto> SelecionarPorNome(string nome);
        IEnumerable<SquadDto> SelecionarSquadsSemTribo();
        SquadDto SelecionarPorNomeEspecifico(string nome);
    }
}