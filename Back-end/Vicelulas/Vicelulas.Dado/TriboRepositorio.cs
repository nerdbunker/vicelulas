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

        public TriboDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.Id, T.Nome ,T.Ativo FROM [TB_tribo] T WHERE T.Nome = '{nome}'");
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

        public int Inserir(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_tribo] (Nome, Ativo) " +
                                                   $"VALUES('{entity.Nome}'," +
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
                                      $"SET Nome = '{entity.Nome}'" +
                                      $"WHERE Id = {entity.Id}");
            }
        }

        public void AlterarStatus(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_tribo] " +
                                   $"SET Ativo = '{entity.Ativo}', " +
                                   $"Nome = '{entity.Nome}'" +
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
