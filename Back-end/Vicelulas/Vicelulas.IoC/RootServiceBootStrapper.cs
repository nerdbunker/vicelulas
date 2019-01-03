using Microsoft.Extensions.DependencyInjection;
using Vicelulas.IoC.Negocio;
using Vicelulas.IoC.Repositorio;

namespace Vicelulas.IoC
{
    public class RootServiceBootStrapper
    {
        public void ChildServiceRegister(IServiceCollection service)
        {
            new NegocioBootStrapper().ChildServiceRegister(service);
            new RepositorioBootStrapper().ChildServiceRegister(service);
        }
    }
}
