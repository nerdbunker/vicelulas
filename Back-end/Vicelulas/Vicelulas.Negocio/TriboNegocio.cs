using System.Collections.Generic;
using Viceluas.Dominio.Dto;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio;

namespace Vicelulas.Negocio
{
    public class TriboNegocio
    {
        private readonly TriboRepositorio _triboRepositorio;

        
        public TriboNegocio()
        {
            _triboRepositorio = new TriboRepositorio();
        }

        public IEnumerable<TriboDto> Selecionar()
        {
            return _triboRepositorio.Selecionar();
        }

        /// <param name="id"></param>
        public TriboDto SelecionarPorId(int id)
        {
            var obj = _triboRepositorio.SelecionarPorId(id);

            if (obj == null)
                throw new NaoEncontradoException("Tribo não encontrada !");

            return obj;
        }

        /// <param name="nome"></param>
        public IEnumerable<TriboDto> SelecionarPorNome(string nome)
        {
            var lista = _triboRepositorio.SelecionarPorNome(nome);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma tribo com esse nome !");

            return lista;
        }

        public int Inserir(Tribo entity)
        {
            var NomeExistente = _triboRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (string.IsNullOrEmpty(entity.Nome))
                throw new ConflitoException("Não é permitido tribo sem nome");

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Tribo cadastrada com este nome {entity.Nome}!");

            return _triboRepositorio.Inserir(entity);
        }

        public TriboDto Alterar(int Id, Tribo entity)
        {
            var idExistente = _triboRepositorio.SelecionarPorId(Id);

            if(idExistente == null)
                throw new NaoEncontradoException($"Não existe esta tribo!");
            

            var NomeExistente = _triboRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente != null)
                throw new ConflitoException($"Já existe uma Tribo cadastrada com este nome {entity.Nome}!");

            entity.Id = Id;
            _triboRepositorio.AlterarNome(entity);

            return _triboRepositorio.SelecionarPorId(Id);
        }

        public TriboDto Desativar(int Id, Tribo entity)
        {
            var idExistente = _triboRepositorio.SelecionarPorId(Id);

            if (idExistente == null)
                throw new NaoEncontradoException($"Não existe esta tribo!");
            

            var NomeExistente = _triboRepositorio.SelecionarPorNomeEspecifico(entity.Nome);

            if (NomeExistente == null)
                throw new NaoEncontradoException($"Não existe uma Tribo cadastrada com este nome {entity.Nome}!");

            entity.Id = Id;
            _triboRepositorio.AlterarStatus(entity);

            return _triboRepositorio.SelecionarPorId(Id);
        }

    }
}
