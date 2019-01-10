using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public IEnumerable<PessoaDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P " +
                                                        $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                        $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                        $"INNER JOIN [TB_squad] S ON P.id_squads = S.id " +
                                                        $"LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id");
                return lista;
            }
        }


        public PessoaDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"LEFT JOIN [TB_squad] S ON P.id_squads = S.id " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE P.Id = @Id", new
                                                                   {
                                                                       Id = id
                                                                   });
                return obj;
            }
        }

        public PessoaDto SelecionarPorEmail(string email)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P  " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"INNER JOIN [TB_squad] S ON P.id_squads = S.Id " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE P.email = @Email", new
                                                                   {
                                                                       Email = email
                                                                   });
                return obj;
            }
        }

        public IEnumerable<PessoaDto> SelecionarPorIdSquad(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P  " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"INNER JOIN [TB_squad] S ON P.id_squads = S.Id " +
                                                                   $"LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE S.Id = @Id", new
                                                                   {
                                                                       Id = id
                                                                   });
                return lista;
            }
        }

        public IEnumerable<PessoaDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P   " +
                                                       $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                       $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                       $"LEFT JOIN [TB_squad] S ON P.id_squads = S.Id " +
                                                       $"LEFT JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                       $"WHERE P.Nome LIKE @Nome ", new
                                                       {
                                                           Nome = "%" + nome + "%"
                                                       });

                return lista;
            }
        }

        public PessoaDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, P.Ativo, P.id_squads , P.id_unidade, P.permissao FROM [TB_pessoa] P " +
                                                                    $"WHERE P.Nome = @Nome", new
                                                                    {
                                                                        Nome = nome
                                                                    });
                return obj;
            }
        }

        public int Inserir(Pessoa entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_pessoa] (Id_papel, Nome, Email, password, ativo, Id_squads, Id_unidade, Permissao) " +
                                                   $"VALUES(@idPapel, " +
                                                   $"@nome, " +
                                                   $"@email, " +
                                                   $"@senha, " +
                                                   $"@ativo," +
                                                   $"@idSquad," +
                                                   $"@idUnidade," +
                                                   $"@permissao); " +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id", new
                                                   {
                                                       idPapel = entity.Id_papel,
                                                       nome = entity.Nome,
                                                       email = entity.Email,
                                                       senha = entity.Senha,
                                                       ativo = entity.Ativo,
                                                       idSquad = entity.Id_squad,
                                                       idUnidade = entity.Id_unidade,
                                                       permissao = entity.Permissao
                                                   });
            }
        }

        public void Alterar(Pessoa entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_pessoa] " +
                               $"SET Id_papel = @idPapel," +
                               $"Nome = @nome," +
                               $"Email = @email," +
                               $"Ativo = @ativo," +
                               $"Id_squads = @idSquad," +
                               $"Id_unidade = @idUnidade," +
                               $"Permissao = @permissao " +
                               $"WHERE Id = @id", new
                               {
                                   idPapel = entity.Id_papel,
                                   nome = entity.Nome,
                                   email = entity.Email,
                                   ativo = entity.Ativo,
                                   idSquad = entity.Id_squad,
                                   idUnidade = entity.Id_unidade,
                                   permissao = entity.Permissao,
                                   id = entity.Id
                               });
            }
        }

        /// <summary>
        /// Ativar/Desativar Pessoas
        /// </summary>
        /// <param name="id"></param>
        public void AtivarDesativarPessoa(int id, bool ativo)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {

                connection.Execute($"UPDATE [TB_pessoa]" +
                                   $"SET Ativo = @Ativo " +
                                   $"WHERE Id = @Id" , new
                                   {
                                       Ativo = ativo,
                                       Id = id
                                   });
            }

        }

    }
}
