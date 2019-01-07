using System;

namespace Vicelulas.Dominio.Exceções
{
    [Serializable]
    public class RecusadoException : Exception
    {
        public RecusadoException()
        {
        }

        public RecusadoException(int id)
        {
        }

        public RecusadoException(string message) : base(message)
        {
        }

    }
}
