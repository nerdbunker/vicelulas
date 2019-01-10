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
                var lista = connection.Query<TriboDto>($"SELECT T.id, T.nome, T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
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
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                                   $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON " +
                                                                   $"M.id_pessoa = P.id WHERE T.Id = @Id", new
                                                                   {
                                                                       Id = id
                                                                   });
                return obj;
            }
        }

        public  TriboDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<TriboDto>($"SELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                                   $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON " +
                                                                   $"M.id_pessoa = P.id WHERE T.Nome = @Nome", new
                                                                   {
                                                                       Nome = nome
                                                                   });
                return  obj;
            }
        }

        public  IEnumerable<TriboDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<TriboDto>($"SELECT T.id, T.nome , T.ativo, M.id AS IdMentor, P.nome AS NomeMentor FROM [TB_tribo] T " +
                                                       $"LEFT JOIN TB_mentor M ON T.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON " +
                                                       $"M.id_pessoa = P.id WHERE T.Nome LIKE @Nome" , new
                                                       {
                                                           Nome = "%" + nome + "%"
                                                       });

                return  lista;
            }
        }

        public int Inserir(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_tribo] (Nome, Id_mentor, Ativo) " +
                                                   $"VALUES(@nome, " +
                                                   $" @idMentor, " +
                                                   $"@ativo);" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id", new
                                                   {
                                                       nome = entity.Nome,
                                                       idMentor = entity.Id_Mentor,
                                                       ativo = entity.Ativo
                                                   });
            }
        }

        public void AlterarNome(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_tribo] " +
                                      $"SET Nome = @nome " +
                                      $"WHERE Id = @id", new
                                      {
                                          nome = entity.Nome,
                                          id = entity.Id
                                      });
            }
        }

        public void AlterarStatus(Tribo entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_tribo] " +
                                   $"SET Ativo = @ativo, " +
                                   $"Nome = @nome, " +
                                   $"Id_Mentor = @idMentor " +
                                   $"WHERE Id = @id", new
                                   {
                                       ativo = entity.Ativo,
                                       nome = entity.Nome,
                                       idMentor = entity.Id_Mentor,
                                       id = entity.Id
                                   });
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
                                   $"SET Ativo = @Ativo " +
                                   $"WHERE Id = @Id", new
                                   {
                                       Ativo = ativo,
                                       Id = id
                                   });
            }

        }
    }
}
