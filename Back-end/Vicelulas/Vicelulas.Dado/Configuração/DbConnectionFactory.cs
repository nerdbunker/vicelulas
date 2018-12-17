using System;
using System.Collections.Generic;
using System.Text;

namespace Vicelulas.Dado.Configuração
{
    internal static class DbConnectionFactory
    {
        public static string SQLConnectionString => "Data Source=.;Initial Catalog=Vicelulas;Integrated Security=True";
    }
}
