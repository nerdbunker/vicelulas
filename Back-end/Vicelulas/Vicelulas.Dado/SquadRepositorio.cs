using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;

namespace Vicelulas.Dado
{
    public class SquadRepositorio : ISquadRepositorio
    {
        public  IEnumerable<SquadDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome, S.Nome, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " + 
                                                       $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id ");
                return  lista;
            }
        }

        public SquadDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome, S.Nome, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                                   $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                                   $"WHERE S.Id = {id}");
                return obj;
            }
        }

        public  IEnumerable<SquadDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome, S.Nome, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                       $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                       $"WHERE S.Nome LIKE '%{nome}%'");

                return  lista;
            }
        }

        public  SquadDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome, S.Nome, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                                   $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                                   $"WHERE S.Nome = '{nome}'");
                return  obj;
            }
        }

        public  IEnumerable<SquadDto> SelecionarPorIdTribo(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S " +
                                                       $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                       $"WHERE S.Id_Tribo = {id}");
                return lista;
            }
        }

        public  IEnumerable<SquadDto> SelecionarSquadsSemTribo()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_squad] S " +
                                                       $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                       $"WHERE S.Id_Tribo IS NULL");
                return  lista;
            }
        }

        public int Inserir(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_squad] (Id_tribo, Nome, Id_mentor, Ativo) " +
                                                   $"VALUES('{entity.Id_tribo}'," +
                                                   $"'{entity.Nome}'," +
                                                   $"{entity.Id_mentor}," +
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
                                      $" Id_mentor = {entity.Id_mentor}, " +
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
                                   $"Nome = '{entity.Nome}'," +
                                   $"Id_mentor = {entity.Id_mentor}" +
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
