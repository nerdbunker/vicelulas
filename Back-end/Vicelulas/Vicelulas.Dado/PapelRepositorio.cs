using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class PapelRepositorio : IPapelRepositorio
    {
        public IEnumerable<PapelDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PapelDto>($"SELECT P.Id, P.Cargo FROM [TB_papel] P");
                return lista;
            }
        }
    }
}
