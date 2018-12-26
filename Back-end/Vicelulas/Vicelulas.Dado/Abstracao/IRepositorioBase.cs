using System.Collections.Generic;

namespace Vicelulas.Dado.Abstração
{
    internal interface IRepositorioBase<T> where T : class
    {
        IEnumerable<T> Selecionar();
        T SelecionarPorId(int id);
        int Inserir(T entity);
        void Alterar(T entity);
        void Deletar(int id);
    }
}
