using Vicelulas.Dominio.Seguranca;
using Xunit;

namespace Vicelulas.Teste.DominioTeste
{
    public class PasswordHashTeste
    {
        [Fact]
        public void RetornaOkComparacaoHash()
        {
             
            var senha = "123Aa321";
            var hash = PasswordHash.Create(senha);
            var hashTeste = "3a2a61c6a7c040dd9153b7de23018cda";

            Assert.Equal(hash, hashTeste);
        }

        [Fact]
        public void RetornaFalseComparacaoHash()
        {
            var senha = "123Aa321";
            var hash = PasswordHash.Create(senha);
            var hashTeste = "3a2a61c6a7c01232132118cda";

            Assert.NotEqual(hash, hashTeste);
        }
    }
}
