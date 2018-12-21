    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viceluas.Dominio.Dto;

namespace Vicelulas.DBMock.Repositorios
{
    class RepositiorioSquad
    {
        public List<SquadDto> ObterSquad(string nome = null)
        {
            if (nome == null)
            {
                return DbMock.Squad;
            }
            else
            {
                return DbMock.Squad.Where(c => c.Nome.Contains(nome)).ToList();
            }
        }

        public SquadDto ObterSquad(int Id)
        {
            return DbMock.Squad.First(c => c.Id == Id);
        }

        public SquadDto Adicionar(int id_tribo, string nome, string nome_tribo, bool ativo)
        {
            var squad = new SquadDto
            {
                Id = DbMock.NovoId,
                Id_Tribo = id_tribo,
                Nome = nome,
                NomeTribo = nome_tribo,
                Ativo = ativo
            };

            DbMock.Squad.Add(squad);
            return squad;
        }

        public void Atualizar(int Id, int id_tribo, string nome, string nome_tribo, bool ativo)
        {
            var squad = ObterSquad(Id);
            squad.Id_Tribo = id_tribo;
            squad.Nome = nome;
            squad.NomeTribo = nome_tribo;
            squad.Ativo = ativo;
        }

        public void Excluir(int Id)
        {
            var squad = ObterSquad(Id);
            DbMock.Squad.Remove(squad);
        }
    }
}
