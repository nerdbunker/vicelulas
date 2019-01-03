using System.Collections.Generic;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public interface IPessoaRepositorio
    {
        void Alterar(Pessoa entity);
        void AtivarDesativarPessoa(int id, bool ativo);
        int Inserir(Pessoa entity);
        IEnumerable<PessoaDto> Selecionar();
        PessoaDto SelecionarPorEmail(string email);
        PessoaDto SelecionarPorId(int id);
        IEnumerable<PessoaDto> SelecionarPorIdSquad(int id);
        IEnumerable<PessoaDto> SelecionarPorNome(string nome);
        PessoaDto SelecionarPorNomeEspecifico(string nome);
    }
}