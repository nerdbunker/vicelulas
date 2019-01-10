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
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Nome, P.email, P.id_squads, P.Ativo, P.permissao FROM [TB_pessoa] P " +
                                                                   $"WHERE P.email = @Email AND P.password = @Senha ", new
                                                                   {
                                                                       Email = username,
                                                                       Senha = password
                                                                   });
                return obj;
            }
        }
    }
}
