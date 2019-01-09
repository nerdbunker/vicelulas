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
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads, P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"WHERE P.email = '{username}' AND P.password = '{password}' ");
                return obj;
            }
        }
    }
}
