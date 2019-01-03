using System.Collections.Generic;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public interface IPessoaNegocio
    {
        PessoaDto Alterar(int Id, Pessoa entity);
        void AtivarDesativarPessoa(int id);
        int Inserir(Pessoa entity);
        IEnumerable<PessoaDto> Selecionar();
        PessoaDto SelecionarPorId(int id);
        IEnumerable<PessoaDto> SelecionarPorIdSquad(int id);
        IEnumerable<PessoaDto> SelecionarPorNome(string nome);
    }
}