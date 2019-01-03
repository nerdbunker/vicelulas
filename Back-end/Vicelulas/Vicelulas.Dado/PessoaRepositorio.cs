using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class PessoaRepositorio
    {
        public IEnumerable<PessoaDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P " +
                                                        $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                        $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                        $"INNER JOIN [TB_squad] S ON P.id_squads = S.id " +
                                                        $"INNER JOIN [TB_tribo] T ON S.id_tribo = T.id");
                return lista;
            }
        }


        public PessoaDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, S.Nome As SquadNome, T.id As id_tribo, T.nome As TriboNome, P.id_unidade, U.nome As Unidade, P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id "+
                                                                   $"INNER JOIN [TB_squad] S ON P.id_squads = S.id " +
                                                                   $"INNER JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE P.Id = {id}");
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
                                                                   $"INNER JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE P.email = '{email}'");
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
                                                                   $"INNER JOIN [TB_squad] S ON P.id_squads = S.Id "+
                                                                   $"INNER JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                                   $"WHERE S.Id = {id}");
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
                                                       $"INNER JOIN [TB_squad] S ON P.id_squads = S.Id " +
                                                       $"INNER JOIN [TB_tribo] T ON S.id_tribo = T.id " +
                                                       $"WHERE P.Nome LIKE '%{nome}%'");

                return lista;
            }
        }

        public PessoaDto SelecionarPorNomeEspecifico(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_login, P.Id_Papel, P.Nome, P.email, P.Ativo, P.id_squads , P.id_unidade, P.permissao FROM [TB_pessoa] P " +
                                                                    $"WHERE P.Nome = '{nome}'");
                return obj;
            }
        }

        public int Inserir(Pessoa entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int;" +
                                                   $"INSERT INTO [TB_pessoa] (Id_login, Id_papel, Nome, Email, Ativo, Id_squads, Id_unidade, Permissao) " +
                                                   $"VALUES({entity.Id_login}," +
                                                   $"{entity.Id_papel}, " +
                                                   $"'{entity.Nome}', " +
                                                   $"'{entity.Email}', " +
                                                   $"'{entity.Ativo}'," +
                                                   $"{entity.Id_squad}," +
                                                   $"{entity.Id_unidade}," +
                                                   $"{entity.Permissao}); " +
                                                   $"SET @Id = SCOPE_IDENTITY();" +
                                                   $"SELECT @Id");
            }
        }

        public void Alterar(Pessoa entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                connection.Execute($"UPDATE [TB_pessoa] " +
                                      $"SET Id_papel = {entity.Id_papel},"+                          
                                      $"Nome = '{entity.Nome}'," +
                                      $"Email = '{entity.Email}'," +
                                      $"Ativo = '{entity.Ativo}'," +
                                      $"Id_squads = {entity.Id_squad}," +
                                      $"Id_unidade = {entity.Id_unidade}," +
                                      $"Permissao = {entity.Permissao}" +
                                      $"WHERE Id = {entity.Id}");
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
                                   $"SET Ativo = '{ativo}' " +
                                   $"WHERE Id = {id}");
            }

        }

    }
}
