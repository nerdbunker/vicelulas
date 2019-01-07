using System.Collections.Generic;
using System.Linq;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.DBMock.Repositorios
{
    public class RepositorioTribo
    {
        public List<TriboDto> ObterTribo(string nome = null)
        {
            if(nome == null)
            {
                return DbMock.Tribo;
            }
            else
            {
                return DbMock.Tribo.Where(c => c.Nome.Contains(nome)).ToList();
            }
        }

        public TriboDto ObterTribo(int Id)
        {
            return DbMock.Tribo.First(c => c.Id == Id);
        }

        public TriboDto Adicionar(string nome, bool ativo)
        {
            var tribo = new TriboDto
            {
                Id = DbMock.NovoId,
                Nome = nome,
                Ativo = ativo
            };

            DbMock.Tribo.Add(tribo);
            return tribo;

        }

        public void Atualizar(int Id, string nome, bool ativo)
        {
            var tribo = ObterTribo(Id);
            tribo.Nome = nome;
            tribo.Ativo = ativo;
        }

        public void Excluir(int Id)
        {
            var tribo = ObterTribo(Id);
            DbMock.Tribo.Remove(tribo);
        }
    }
}
 