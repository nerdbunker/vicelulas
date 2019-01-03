using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Viceluas.Dominio.Dto;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;

namespace Vicelulas.Dado
{
    public class SquadRepositorio : ISquadRepositorio
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

        public SquadDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo, S.Nome, S.Nome, S.Ativo FROM [TB_squad] S " +
                                                                   $"WHERE S.Nome = '{nome}'");
                return obj;
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

        public int Inserir(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_squad] (Id_tribo, Nome, Ativo) " +
                                                   $"VALUES('{entity.Id_tribo}'," +
                                                   $"'{entity.Nome}'," +
                                                   $"'{entity.Ativo}');" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id");
            }
        }

        public void Alterar(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_squad] " +
                                      $"SET Nome = '{entity.Nome}'," +
                                      $"Id_tribo = {entity.Id_tribo}" +
                                      $"WHERE Id = {entity.Id}");
            }
        }

        public void AlterarStatus(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_squad] " +
                                   $"SET Ativo = '{entity.Ativo}', " +
                                   $"Nome = '{entity.Nome}'" +
                                   $"WHERE Id = {entity.Id}");
            }
        }

        /// <summary>
        /// Ativar/Desativar Squad
        /// </summary>
        /// <param name="id"></param>
        public void AtivarDesativarSquad(int id, bool ativo)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {

                connection.Execute($"UPDATE [TB_squad]" +
                                   $"SET Ativo = '{ativo}' " +
                                   $"WHERE Id = {id}");
            }

        }



    }
}
