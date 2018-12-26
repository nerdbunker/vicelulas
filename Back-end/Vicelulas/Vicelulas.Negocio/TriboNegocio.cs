using System.Collections.Generic;
using Viceluas.Dominio.Dto;
using Viceluas.Dominio.Exceções;
using Vicelulas.Dado;

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
    }
}
