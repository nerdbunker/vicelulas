using Dapper;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class AutenticacaoRepositorio : IAutenticacaoRepositorio
    {
        public PessoaDto Entrar(string username, string password)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"INNER JOIN [TB_login] L ON P.id_login = L.id "+
                                                                   $"WHERE L.Username = '{username}' AND L.Password = '{password}' ");
                return obj;
            }
        }

        //public int Cadastrar(CadastroPessoa entity)
        //{
        //    using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
        //    {
        //        return connection.QuerySingle<int>($"DECLARE @Id int;" +
        //                                           $"INSERT INTO [TB_login] (username,password) " +
        //                                           $"VALUES('{entity.Email}'," +
        //                                           $"'{entity.Senha}'); " +
        //                                           $"SET @Id = SCOPE_IDENTITY();" +
        //                                           $"SELECT @Id");
        //    }
        //}

        public int SelecionarPorUsername(string username)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<int>($"SELECT L.Id FROM [TB_login] L "+
                                                                $"WHERE L.username = '{username}' ");
                return obj;
            }
        }

    }
}
