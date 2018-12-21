using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Viceluas.Dominio.Dto;

namespace Vicelulas.DBMock
{
    class DbMock
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
                new TriboDto { Id = NovoId, Nome = "Formacao", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "BRINKS", Ativo = true}
            };

            Squad = new List<SquadDto>
            {
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[0].Id , Nome = "NerdBunker", NomeTribo = "Formacao", Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[1].Id , Nome = "NerdBunker", NomeTribo = "Formacao", Ativo = true }
            };
        }
    }
}