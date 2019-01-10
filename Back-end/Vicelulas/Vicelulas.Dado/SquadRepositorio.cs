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
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " + 
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
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                                   $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                                   $"WHERE S.Id = @Id", new
                                                                   {
                                                                       Id = id
                                                                   });
                return obj;
            }
        }

        public  IEnumerable<SquadDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                       $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                       $"WHERE S.Nome LIKE @Nome ", new
                                                       {
                                                           Nome = "%" + nome + "%"
                                                       });

                return  lista;
            }
        }

        public  SquadDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                                   $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                                   $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                                   $"WHERE S.Nome = @Nome ", new
                                                                   {
                                                                       Nome = nome
                                                                   });
                return  obj;
            }
        }

        public  IEnumerable<SquadDto> SelecionarPorIdTribo(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
                                                       $"INNER JOIN [TB_tribo] T ON S.Id_Tribo = T.Id " +
                                                       $"LEFT JOIN TB_mentor M ON S.id_mentor = M.id " +
                                                       $"LEFT JOIN TB_pessoa P ON M.id_pessoa = P.id " +
                                                       $"WHERE S.Id_Tribo = @Id ", new
                                                       {
                                                           Id = id
                                                       });
                return lista;
            }
        }

        public  IEnumerable<SquadDto> SelecionarSquadsSemTribo()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<SquadDto>($"SELECT S.Id, S.Id_Tribo, T.Nome AS NomeTribo, S.Nome AS NomeSquad, S.Ativo, M.id AS IdMentor, P.nome FROM [TB_squad] S " +
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
                                                   $"VALUES(@idTribo," +
                                                   $"@nome," +
                                                   $"@IdMentor," +
                                                   $"@ativo);" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id", new
                                                   {
                                                       idTribo = entity.Id_tribo,
                                                       nome = entity.Nome,
                                                       IdMentor = entity.Id_Mentor,
                                                       ativo = entity.Ativo
                                                   });
            }
        }

        public int InserirSemTribo(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_squad] (Nome, Id_mentor, Ativo) " +
                                                   $"VALUES(@nome," +
                                                   $"@idMentor," +
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

        public int InserirSemMentor(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_squad] (Id_tribo, Nome, Ativo) " +
                                                   $"VALUES(@idTribo," +
                                                   $"@nome," +
                                                   $"@ativo);" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id" , new
                                                   {
                                                       idTribo = entity.Id_tribo,
                                                       nome = entity.Nome,
                                                       ativo = entity.Ativo
                                                   });
            }
        }

        public int InserirSemTriboEMentor(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_squad] (Nome, Ativo) " +
                                                   $"VALUES(@nome," +
                                                   $"@ativo);" +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id" , new
                                                   {
                                                       nome = entity.Nome,
                                                       ativo = entity.Ativo
                                                   });
            }
        }

        public void Alterar(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_squad] " +
                                      $"SET Nome = @nome," +
                                      $" Id_mentor = @idMentor, " +
                                      $"Id_tribo = @idTribo " +
                                      $"WHERE Id = @id", new
                                      {
                                          nome = entity.Nome,
                                          idMentor = entity.Id_Mentor,
                                          idTribo = entity.Id_tribo,
                                          id = entity.Id
                                      });
            }
        }

        public void AlterarStatus(Squad entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_squad] " +
                                   $"SET Ativo = @ativo, " +
                                   $"Nome = @nome," +
                                   $"Id_mentor = @idMentor" +
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
        /// Ativar/Desativar Squad
        /// </summary>
        /// <param name="id"></param>
        public void AtivarDesativarSquad(int id, bool ativo)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {

                connection.Execute($"UPDATE [TB_squad]" +
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
