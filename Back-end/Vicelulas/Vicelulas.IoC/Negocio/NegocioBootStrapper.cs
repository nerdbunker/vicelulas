using Microsoft.Extensions.DependencyInjection;
using Vicelulas.Negocio;

namespace Vicelulas.IoC.Negocio
{
    internal class NegocioBootStrapper
    {
        internal void ChildServiceRegister(IServiceCollection service)
        {
            service.AddScoped<IUnidadeNegocio, UnidadeNegocio>();
            service.AddScoped<ITriboNegocio, TriboNegocio>();
            service.AddScoped<ISquadNegocio, SquadNegocio>();
            service.AddScoped<IPessoaNegocio, PessoaNegocio>();
            service.AddScoped<IPapelNegocio, PapelNegocio>();
            service.AddScoped<IAutenticacaoNegocio, AutenticacaoNegocio>();
        }
    }
}
