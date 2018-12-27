using System.Collections.Generic;
using Viceluas.Dominio.Dto;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio;

namespace Vicelulas.Negocio
{
    public class SquadNegocio
    {
        private readonly SquadRepositorio _squadRepositorio;


        public SquadNegocio()
        {
            _squadRepositorio = new SquadRepositorio();
        }

        public IEnumerable<SquadDto> Selecionar()
        {
            return _squadRepositorio.Selecionar();
        }

        /// <param name="id"></param>
        public SquadDto SelecionarPorId(int id)
        {
            var obj = _squadRepositorio.SelecionarPorId(id);

            if (obj == null)
                throw new NaoEncontradoException("Squad não encontrada !");

            return obj;
        }

        /// <param name="nome"></param>
        public IEnumerable<SquadDto> SelecionarPorNome(string nome)
        {
            var lista = _squadRepositorio.SelecionarPorNome(nome);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma squad com esse nome !");

            return lista;
        }

        /// <param name="id"></param>
        public IEnumerable<SquadDto> SelecionarPorIdTribo(int id)
        {
            var lista = _squadRepositorio.SelecionarPorIdTribo(id);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma squad dessa tribo !");

            return lista;
        }

        /// <param name="entity"></param>
        public int Inserir(Squad entity)
        {
            var NomeExistente = _squadRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (string.IsNullOrEmpty(entity.Nome))
                throw new ConflitoException("Não é permitido tribo sem nome");

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Squad cadastrada com este nome {entity.Nome}!");

            return _squadRepositorio.Inserir(entity);
        }

        /// <param name="Id, entity"></param>
        public SquadDto Alterar(int Id, Squad entity)
        {
            var idExistente = _squadRepositorio.SelecionarPorId(Id);

            if (idExistente == null)
                throw new NaoEncontradoException($"Não existe esta Squad!");
            

            var NomeExistente = _squadRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Squad cadastrada com este nome {entity.Nome}!");

            entity.Id = Id;
            _squadRepositorio.Alterar(entity);

            return _squadRepositorio.SelecionarPorId(Id);
        }

        /// <param name="Id, entity"></param>
        public SquadDto Desativar(int Id, Squad entity)
        {
            var idExistente = _squadRepositorio.SelecionarPorId(Id);

            if (idExistente == null)
                throw new NaoEncontradoException($"Não existe esta Squad!");
            

            var NomeExistente = _squadRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente == null)
                throw new NaoEncontradoException($"Não existe uma Squad cadastrada com este nome {entity.Nome}!");

            entity.Id = Id;
            _squadRepositorio.AlterarStatus(entity);

            return _squadRepositorio.SelecionarPorId(Id);
        }

    }
}
