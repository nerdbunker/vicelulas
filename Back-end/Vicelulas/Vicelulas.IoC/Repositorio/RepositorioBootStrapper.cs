using Microsoft.Extensions.DependencyInjection;
using Vicelulas.Dado;

namespace Vicelulas.IoC.Repositorio
{
    internal class RepositorioBootStrapper
    {
        internal void ChildServiceRegister(IServiceCollection service)
        {
            service.AddScoped<IUnidadeRepositorio, UnidadeRepositorio>();
            service.AddScoped<ITriboRepositorio, TriboRepositorio>();
            service.AddScoped<ISquadRepositorio, SquadRepositorio>();
            service.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
            service.AddScoped<IPapelRepositorio, PapelRepositorio>();
            service.AddScoped<IAutenticacaoRepositorio, AutenticacaoRepositorio>();
        }
    }
}
