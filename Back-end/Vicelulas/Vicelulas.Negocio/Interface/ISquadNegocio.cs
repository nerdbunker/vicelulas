﻿using System.Collections.Generic;
using Vicelulas.Dominio.Dto;
using Vicelulas.Dominio;
using System;

namespace Vicelulas.Negocio
{
    public interface ISquadNegocio
    {
        SquadDto Alterar(int Id, Squad entity);
        void AtivarDesativarSquad(int id);
        SquadDto Desativar(int Id, Squad entity);
        int Inserir(Squad entity);
        IEnumerable<SquadDto> Selecionar();
        SquadDto SelecionarPorId(int id);
        IEnumerable<SquadDto> SelecionarPorIdTribo(int id);
        IEnumerable<SquadDto> SelecionarPorNome(string nome);
        IEnumerable<SquadDto> SelecionarSquadsSemTribo();
    }
}