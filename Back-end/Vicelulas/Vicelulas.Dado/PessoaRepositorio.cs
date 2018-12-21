using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vicelulas.Dado.Configuração;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.Dado
{
    public class PessoaRepositorio
    {
        public IEnumerable<PessoaDto> Selecionar()
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P " +
                                                        $" INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                        $" INNER JOIN [TB_unidade] U ON P.id_unidade = U.id ");
                return lista;
            }
        }


        public PessoaDto SelecionarPorId(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id "+
                                                                   $"WHERE P.Id = {id}");
                return obj;
            }
        }

        public IEnumerable<PessoaDto> SelecionarPorIdSquad(int id)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P " +
                                                                   $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                                   $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                                   $"INNER JOIN [TB_squad] S ON P.id_squads = S.Id "+
                                                                   $"WHERE S.Id = {id}");
                return lista;
            }
        }


        public IEnumerable<PessoaDto> SelecionarPorNome(string nome)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var lista = connection.Query<PessoaDto>($"SELECT P.Id, P.Id_Papel, P.Nome, P.email, C.Cargo, P.Ativo, P.id_squads , P.id_unidade, U.nome AS Unidade , P.permissao FROM [TB_pessoa] P " +
                                                       $"INNER JOIN [TB_papel] C ON P.id_papel = C.Id " +
                                                       $"INNER JOIN [TB_unidade] U ON P.id_unidade = U.id " +
                                                       $"WHERE P.Nome LIKE '%{nome}%'");

                return lista;
            }
        }
    }
}
