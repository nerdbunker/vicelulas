﻿using System;

namespace Viceluas.Dominio.Exceções
{
    [Serializable]
    public class ConflitoException : Exception
    {
        public ConflitoException()
        {
        }

        public ConflitoException(int id)
        {
        }

        public ConflitoException(string message) : base(message)
        {
        }
    }
}
