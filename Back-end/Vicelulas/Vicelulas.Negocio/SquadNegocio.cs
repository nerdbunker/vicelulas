using System;
using System.Collections.Generic;
using System.Text;
using Viceluas.Dominio.Dto;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;

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

    }
}
