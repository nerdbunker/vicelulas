using System.Collections.Generic;
using Viceluas.Dominio.Dto;
using Vicelulas.Dominio;

namespace Vicelulas.Dado
{
    public interface ITriboRepositorio
    {
        void AlterarNome(Tribo entity);
        void AlterarStatus(Tribo entity);
        void AtivarDesativarTribo(int id, bool ativo);
        int Inserir(Tribo entity);
        IEnumerable<TriboDto> Selecionar();
        TriboDto SelecionarPorId(int id);
        IEnumerable<TriboDto> SelecionarPorNome(string nome);
        TriboDto SelecionarPorNomeEspecifico(string nome);
    }
}