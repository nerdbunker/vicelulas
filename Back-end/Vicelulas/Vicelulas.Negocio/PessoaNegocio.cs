using System;
using System.Collections.Generic;
using System.Text;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Negocio
{
    public class PessoaNegocio
    {
        private readonly PessoaRepositorio _pessoaRepositorio;

        public PessoaNegocio()
        {
            _pessoaRepositorio = new PessoaRepositorio();
        }

        public IEnumerable<PessoaDto> Selecionar()
        {
            return _pessoaRepositorio.Selecionar();
        }

        /// <param name="id"></param>
        public PessoaDto SelecionarPorId(int id)
        {
            var obj = _pessoaRepositorio.SelecionarPorId(id);

            if (obj == null)
                throw new NaoEncontradoException("Pessoa não encontrada !");

            return obj;
        }

        /// <param name="nome"></param>
        public IEnumerable<PessoaDto> SelecionarPorNome(string nome)
        {
            var lista = _pessoaRepositorio.SelecionarPorNome(nome);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma pessoa com esse nome !");

            return lista;
        }

        /// <param name="id"></param>
        public IEnumerable<PessoaDto> SelecionarPorIdSquad(int id)
        {
            var lista = _pessoaRepositorio.SelecionarPorIdSquad(id);

            if (lista == null)
                throw new NaoEncontradoException("Não foi encontrada nenhuma pessoa nesse squad !");

            return lista;
        }
    }
}
