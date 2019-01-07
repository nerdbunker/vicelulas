using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Text;

namespace Vicelulas.Dominio.Seguranca
{
    public class PasswordHash
    {
        public static string Create(string value)
        {
            var valueBytes = KeyDerivation.Pbkdf2(
                                password: value,
                                salt: Encoding.UTF8.GetBytes("Vicelulas"),
                                prf: KeyDerivationPrf.HMACSHA512,
                                iterationCount: 10000,
                                numBytesRequested: 256 / 8);
           

            return Convert.ToBase64String(valueBytes);
        }


        public static bool Validate(string value, string hash)
            => Create(value) == hash;
    }
}
