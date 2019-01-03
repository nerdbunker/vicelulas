using System.Collections.Generic;
using Viceluas.Dominio.Dto;
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
        SquadDto SelecionarPorNomeEspecifico(string nome);
    }
}