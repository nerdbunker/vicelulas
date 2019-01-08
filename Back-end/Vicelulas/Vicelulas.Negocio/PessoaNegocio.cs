using System.Collections.Generic;
using Vicelulas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class PessoaNegocio : IPessoaNegocio
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaNegocio(IPessoaRepositorio _pessoaRepositorio)
        {
            this._pessoaRepositorio = _pessoaRepositorio;
        }

        public  IEnumerable<PessoaDto> Selecionar()
        {
            return  _pessoaRepositorio.Selecionar();
        }

        /// param name="id">/param>
        public PessoaDto SelecionarPorId(int id)
        {
            var obj = _pessoaRepositorio.SelecionarPorId(id);

            if (obj == null)
                throw new NaoEncontradoException("Pessoa não encontrada !");

            return  obj;
        }

        /// param name="nome">/param>
        public  IEnumerable<PessoaDto> SelecionarPorNome(string nome)
        {
            var lista = _pessoaRepositorio.SelecionarPorNome(nome);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma pessoa com esse nome !");

            return  lista;
        }

        /// param name="id">/param>
        public  IEnumerable<PessoaDto> SelecionarPorIdSquad(int id)
        {
            var lista = _pessoaRepositorio.SelecionarPorIdSquad(id);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma pessoa nesse squad !");

            return  lista;
        }

        /// param name="entity">/param>
        public int Inserir(Pessoa entity)
        {
            var NomeExistente = _pessoaRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Pessoa cadastrada com este nome {entity.Nome}!");

            var EmailExistente = _pessoaRepositorio.SelecionarPorEmail(entity.Email);

            if (EmailExistente != null)
                throw new ConflitoException($"Já existe uma Pessoa cadastrada com este Email {entity.Email}!");

            return _pessoaRepositorio.Inserir(entity);
        }

        /// param name="Id, entity">/param>
        public PessoaDto Alterar(int Id, Pessoa entity)
        {
            var idExistente = _pessoaRepositorio.SelecionarPorId(Id);
            

            if (idExistente == null)
            {
                throw new NaoEncontradoException($"Não existe esta Pessoa!");
            }

            var NomeExistente = _pessoaRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Pessoa cadastrada com este nome {entity.Nome}!");

            var EmailExistente = _pessoaRepositorio.SelecionarPorEmail(entity.Email);

            if (EmailExistente != null)
                throw new ConflitoException($"Já esxiste uma pessoa cadastrada com este email {entity.Email}!");

            entity.Id = Id;
            _pessoaRepositorio.Alterar(entity);

            return  _pessoaRepositorio.SelecionarPorId(Id);
        }

        /// param name="Id">/param>
        public void AtivarDesativarPessoa(int id)
        {
            var obj = _pessoaRepositorio.SelecionarPorId(id);

            if (obj == null)
                throw new NaoEncontradoException($"Não existe uma Pessoa com o id {id}");

           _pessoaRepositorio.AtivarDesativarPessoa(id, !obj.Ativo);
        }

    }
}
