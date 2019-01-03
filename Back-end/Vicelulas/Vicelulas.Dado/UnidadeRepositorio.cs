using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class UnidadeRepositorio : IUnidadeRepositorio
    {
        public IEnumerable<UnidadeDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<UnidadeDto>($"SELECT U.id, U.nome, E.pais, E.estado, E.cidade, E.bairro, E.logradouro, E.complemento, E.numero, E.codigo_postal FROM TB_unidade U " +
                                                         $"INNER JOIN [TB_endereco] E ON U.id = E.id ");
                return lista;
            }
        }

    }   
}
