using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Viceluas.Dominio.Dto;
using Vicelulas.Dado.Configuração;

namespace Vicelulas.Dado
{
    public class TriboRepositorio
    {
        public IEnumerable<TriboDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<TriboDto>($"SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T");
                return lista;
            }
        }

        public TriboDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T WHERE T.Id = {id}");
                return obj;
            }
        }

        public IEnumerable<TriboDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<TriboDto>($"SELECT T.Id, T.Nome, T.Ativo FROM [TB_tribo] T WHERE T.Nome LIKE '%{nome}%'");

                return lista;
            }
        }
    }
}
