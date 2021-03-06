﻿using System.Collections.Generic;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dominio;

namespace Vicelulas.Negocio
{
    public interface ITriboNegocio
    {
        TriboDto Alterar(int Id, Tribo entity);
        void AtivarDesativarTribo(int id);
        int Inserir(Tribo entity);
        IEnumerable<TriboDto> Selecionar();
        TriboDto SelecionarPorId(int id);
        IEnumerable<TriboDto> SelecionarPorNome(string nome);
    }
}