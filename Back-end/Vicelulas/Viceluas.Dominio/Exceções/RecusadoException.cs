using System;
using System.Collections.Generic;
using System.Text;

namespace Viceluas.Dominio.Exceções
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
