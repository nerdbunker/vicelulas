namespace Vicelulas.Dado.Configuração
{
    internal static class DbConnectionFactory
    {
        public static string SQLConnectionString => "Data Source=WKSJUN000465;Persist Security Info=False;User ID=sa;Password=123Aa321; Database=Vicelulas;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        public static string SQLConnectionString => "Data Source=.;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True; Database=Vicelulas;";
    }
}
