using System;
using System.Collections.Generic;
using System.Text;

namespace Vicelulas.Dominio
{
    public class CadastroPessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Id_squads { get; set; }
        public int Id_unidade { get; set; }
        public int Id_papel { get; set; }
        
    }
}
