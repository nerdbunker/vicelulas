namespace Vicelulas.Api.Model
{
    public class CadastroPessoaInput
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id_squads { get; set; }
        public int Id_unidade { get; set; }
        public int Id_papel { get; set; }

    }
}
