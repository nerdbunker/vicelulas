using System;

namespace Vicelulas.Dominio.Dto
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public int Id_Papel { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }

        public Boolean Ativo { get; set; }
        public int Id_Squads { get; set; }
        public int Id_Unidade { get; set; }
        public int Permisao { get; set; }
    }
}
