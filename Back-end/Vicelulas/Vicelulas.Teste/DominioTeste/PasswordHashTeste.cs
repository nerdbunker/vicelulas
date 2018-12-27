using Vicelulas.Dominio.Seguranca;
using Xunit;

namespace Vicelulas.Teste.DominioTeste
{
    public class PasswordHashTeste
    {
        [Fact]
        public void RetornaOkComparacaoHash()
        {
             
            var senha = "passw0rd";
            var hash = PasswordHash.Create(senha);

            var match = PasswordHash.Validate(senha, hash);

            Assert.True(match);
        }

        [Fact]
        public void RetornaFalseComparacaoHash()
        {
            var senha = "passw0rd";
            var hash =  "password";

            var match = PasswordHash.Validate(senha, hash);

            Assert.False(match);
        }
    }
}
