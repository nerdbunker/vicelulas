namespace Vicelulas.Dominio.Dto
{
    public class SquadDto
    {
        public int Id { get; set; }
        public int Id_Tribo { get; set; }
        public string NomeMentor { get; set; }
        public int IdMentor { get; set; }
        public string NomeTribo { get; set; }
        public bool Ativo { get; set; }
    }
}
