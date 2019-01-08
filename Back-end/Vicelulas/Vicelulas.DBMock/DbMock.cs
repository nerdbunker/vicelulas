using System.Collections.Generic;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.DBMock
{
    public class DbMock
    {
        public static List<TriboDto> Tribo { get; set; }
        public static List<SquadDto> Squad { get; set; }

        private static int _NovoId { get; set; }
        public static int NovoId
        {
            get
            {
                return _NovoId++;
            }
        }

        static DbMock()
        {
            _NovoId = 1;
            Tribo = new List<TriboDto>
            {
                new TriboDto {Id = NovoId, Nome = "Formacao", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "BRINKS", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "Finamax", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "MAPFRE", Ativo = false},
                new TriboDto { Id = NovoId, Nome = "Produtos", Ativo = false},
                new TriboDto { Id = NovoId, Nome = "Consultoria", Ativo = false},
            };

            Squad = new List<SquadDto>
            {
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[0].Id , Nome = "NerdBunker", NomeTribo = Tribo[0].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[1].Id , Nome = "NerdBunker", NomeTribo = Tribo[1].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[2].Id , Nome = "Bug Hunters", NomeTribo = Tribo[2].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[3].Id , Nome = "Unibanco", NomeTribo = Tribo[3].Nome, Ativo = false },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[4].Id , Nome = "Lemoris", NomeTribo = Tribo[4].Nome, Ativo = false },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[5].Id , Nome = "Alpha Noob", NomeTribo = Tribo[5].Nome, Ativo = false },

            };

        }
    }
}