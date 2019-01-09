using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;

namespace Vicelulas.Dado
{
    public class TriboRepositorio : ITriboRepositorio
    {
        public  IEnumerable<TriboDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<TriboDto>($"SELECT T.id, T.nome AS NomeTribo , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                       $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON " +
                                                       $"M.id_pessoa = P.id");
                return  lista;
            }
        }

        public TriboDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.id, T.nome AS NomeTribo , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                                   $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON " +
                                                                   $"M.id_pessoa = P.id WHERE T.Id = {id}");
                return obj;
            }
        }

        public  TriboDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.id, T.nome AS NomeTribo , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                                   $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON " +
                                                                   $"M.id_pessoa = P.id WHERE T.Nome = '{nome}'");
                return  obj;
            }
        }

        public  IEnumerable<TriboDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<TriboDto>($"SELECT T.id, T.nome AS NomeTribo , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                       $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON " +
                                                       $"M.id_pessoa = P.id WHERE T.Nome LIKE '%{nome}%'");

                return  lista;
            }
        }

        public int Inserir(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_tribo] (Nome, Id_mentor, Ativo) " +
                                                   $"VALUES('{entity.Nome}', " +
                                                   $" {entity.Id_Mentor} " +
                                                   $"'{entity.Ativo}');" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id");
            }
        }

        public void AlterarNome(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_tribo] " +
                                      $"SET Nome = '{entity.Nome}', " +
                                      $"id_mentor = {entity.Id_Mentor} " +
                                      $"WHERE Id = {entity.Id}");
            }
        }

        public void AlterarStatus(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_tribo] " +
                                   $"SET Ativo = '{entity.Ativo}', " +
                                   $"Nome = '{entity.Nome}', " +
                                   $"Id_Mentor = {entity.Id_Mentor} " +
                                   $"WHERE Id = {entity.Id}");
            }
        }


        /// <summary>
        /// Ativar/Desativar Tribo
        /// </summary>
        /// <param name="id"></param>
        public void AtivarDesativarTribo(int id, bool ativo)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {

                connection.Execute($"UPDATE [TB_tribo]" +
                                   $"SET Ativo = '{ativo}' " +
                                   $"WHERE Id = {id}");
            }

        }
    }
}
