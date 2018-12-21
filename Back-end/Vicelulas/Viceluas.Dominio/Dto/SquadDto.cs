using System;
using System.Collections.Generic;
using System.Text;

namespace Viceluas.Dominio.Dto
{
    public class SquadDto
    {
        public int Id { get; set; }
        public int Id_Tribo { get; set; }
        public string Nome { get; set; }
        public string NomeTribo { get; set; }
        public Boolean Ativo { get; set; }
    }
}
