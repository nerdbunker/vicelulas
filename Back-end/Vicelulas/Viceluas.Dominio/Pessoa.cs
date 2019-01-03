namespace Vicelulas.Dominio
{
    public class Pessoa
    {
        public int Id { get; set; }

        public int Id_login { get; set; }

        public int Id_papel { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public int Id_squad { get; set; }

        public int Id_unidade { get; set; }

        public int Permissao { get; set; }
    }
}
