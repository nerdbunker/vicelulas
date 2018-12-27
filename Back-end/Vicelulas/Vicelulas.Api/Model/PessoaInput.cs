using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vicelulas.Api.Model
{
    public class PessoaInput
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Id_squads { get; set; }
        public int Id_unidade { get; set; }
        public int Id_papel { get; set; }
        public int Permissao { get; set; }
        public bool Ativo { get; set; }
    }
}
