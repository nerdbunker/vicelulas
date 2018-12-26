using System.Collections.Generic;

namespace Vicelulas.Negocio.Abstração
{
    public interface INegocioBase<T> where T : class
    {
        IEnumerable<T> Selecionar();
        T SelecionarPorId(int id);
        int Inserir(T entity);
        T Alterar(int id, T entity);
        void Deletar(int id);
    }
}
