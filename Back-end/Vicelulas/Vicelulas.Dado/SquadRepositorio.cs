using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Viceluas.Dominio.Dto;
using Vicelulas.Dado.Configuração;

namespace Vicelulas.Dado
{
    public class SquadRepositorio
    {
        public IEnumerable<SquadDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo,T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S " + 
                                                       $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id ");
                return lista;
            }
        }

        public SquadDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo,T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S "+
                                                                   $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id "+
                                                                   $"WHERE S.Id = {id}");
                return obj;
            }
        }

        public IEnumerable<SquadDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S "+ 
                                                       $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id "+ 
                                                       $"WHERE S.Nome LIKE '%{nome}%'");

                return lista;
            }
        }

        public IEnumerable<SquadDto> SelecionarPorIdTribo(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome, S.Ativo FROM [TB_squad] S "+
                                                       $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"WHERE S.Id_Tribo = {id}");
                return lista;
            }
        }
    }
}
