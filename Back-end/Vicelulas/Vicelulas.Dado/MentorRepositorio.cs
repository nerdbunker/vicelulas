using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class MentorRepositorio : IMentorRepositorio
    {
        public IEnumerable<MentorDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<MentorDto>($"SELECT M.id, M.Id_Pessoa, P.nome AS NomePessoa FROM TB_mentor M " +
                                                        $"INNER JOIN TB_pessoa P ON M.id_pessoa = P.id");
                return lista;
            }
        }

        public int Inserir(int entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @Id int; " +
                                                   $"INSERT INTO [TB_mentor] (Id_Pessoa) " +
                                                   $"VALUES({entity}) " +
                                                   $"SET @Id = SCOPE_IDENTITY(); " +
                                                   $"SELECT @Id");
            }
        }
        

    }
}
