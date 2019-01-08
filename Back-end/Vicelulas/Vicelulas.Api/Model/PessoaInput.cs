using Vicelulas.Dominio;

namespace Vicelulas.Api.Model
{
    public class PessoaInput
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Id_squads { get; set; }
        public int Id_unidade { get; set; }
        public int Id_papel { get; set; }
        public int Permissao { get; set; }

    }
}
