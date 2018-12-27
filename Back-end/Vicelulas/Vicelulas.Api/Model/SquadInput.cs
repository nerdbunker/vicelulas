using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vicelulas.Api.Model
{
    public class SquadInput
    {
        public string Nome { get; set; }
        public int Id_tribo { get; set; }
        public bool Ativo { get; set; }
    }
}
