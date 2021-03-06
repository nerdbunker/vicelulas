﻿using System.Collections.Generic;
using Vicelulas.Dominio.Dto;

namespace Vicelulas.DBMock
{
    public class DbMock
    {
        public static List<TriboDto> Tribo { get; set; }
        public static List<SquadDto> Squad { get; set; }
        public static List<PessoaDto> Pessoa { get; set; }
        public static List<PapelDto> Papel { get; set; }
        public static List<UnidadeDto> Unidade { get; set; }
        public static List<MentorDto> Mentor { get; set; }

        private static int _NovoId { get; set; }
        public static int NovoId
        {
            get
            {
                return _NovoId++;
            }
        }

        static DbMock()
        {
            _NovoId = 1;
            Tribo = new List<TriboDto>
            {
                new TriboDto {Id = NovoId, Nome = "Formacao", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "BRINKS", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "Finamax", Ativo = true},
                new TriboDto { Id = NovoId, Nome = "MAPFRE", Ativo = false},
                new TriboDto { Id = NovoId, Nome = "Produtos", Ativo = false},
                new TriboDto { Id = NovoId, Nome = "Consultoria", Ativo = false},
            };

            Squad = new List<SquadDto>
            {
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[0].Id , Nome = "NerdBunker", NomeTribo = Tribo[0].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[1].Id , Nome = "NerdBunker", NomeTribo = Tribo[1].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[2].Id , Nome = "Bug Hunters", NomeTribo = Tribo[2].Nome, Ativo = true },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[3].Id , Nome = "Unibanco", NomeTribo = Tribo[3].Nome, Ativo = false },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[4].Id , Nome = "Lemoris", NomeTribo = Tribo[4].Nome, Ativo = false },
                new SquadDto { Id = NovoId, Id_Tribo = Tribo[5].Id , Nome = "Alpha Noob", NomeTribo = Tribo[5].Nome, Ativo = false },

            };

            Pessoa = new List<PessoaDto>
            {
                new PessoaDto {
                    Id = NovoId,
                    Id_Papel = 1,
                    Nome = "Pedro Aviador",
                    Email = "Pedro@viceri.com",
                    Cargo = "Estagiario",
                    Ativo = true,
                    Id_Squads = Squad[0].Id,
                    Id_Tribo = Tribo[0].Id,
                    Id_Unidade = 1,
                    Permissao = 1,
                    SquadNome = Squad[0].Nome,
                    TriboNome= Tribo[0].Nome,
                    Unidade = "General Osorio" },

                new PessoaDto {
                    Id = NovoId,
                    Id_Papel = 1,
                    Nome = "Isac Patinete",
                    Email = "Isac@viceri.com",
                    Cargo = "Estagiario",
                    Ativo = true,
                    Id_Squads = Squad[0].Id,
                    Id_Tribo = Tribo[0].Id,
                    Id_Unidade = 1,
                    Permissao = 1,
                    SquadNome = Squad[0].Nome,
                    TriboNome= Tribo[0].Nome,
                    Unidade = "General Osorio" },

                new PessoaDto {
                    Id = NovoId,
                    Id_Papel = 1,
                    Nome = "Fernando Pleno",
                    Email = "Fernando@viceri.com",
                    Cargo = "Estagiario",
                    Ativo = true,
                    Id_Squads = Squad[0].Id,
                    Id_Tribo = Tribo[0].Id,
                    Id_Unidade = 1,
                    Permissao = 1,
                    SquadNome = Squad[0].Nome,
                    TriboNome= Tribo[0].Nome,
                    Unidade = "General Osorio" },

                new PessoaDto {
                    Id = NovoId,
                    Id_Papel = 1,
                    Nome = "Lucas Tumulo",
                    Email = "Lucas@viceri.com",
                    Cargo = "Estagiario",
                    Ativo = true,
                    Id_Squads = Squad[0].Id,
                    Id_Tribo = Tribo[0].Id,
                    Id_Unidade = 1,
                    Permissao = 1,
                    SquadNome = Squad[0].Nome,
                    TriboNome= Tribo[0].Nome,
                    Unidade = "General Osorio" },

                new PessoaDto {
                    Id = NovoId,
                    Id_Papel = 1,
                    Nome = "Britao",
                    Email = "brito@viceri.com",
                    Cargo = "Estagiario",
                    Ativo = true,
                    Id_Squads = Squad[0].Id,
                    Id_Tribo = Tribo[0].Id,
                    Id_Unidade = 1,
                    Permissao = 1,
                    SquadNome = Squad[0].Nome,
                    TriboNome= Tribo[0].Nome,
                    Unidade = "General Osorio" },
            };

            Papel = new List<PapelDto>
            {
                new PapelDto { Id = NovoId, Cargo = "Estagiario" },
                new PapelDto { Id = NovoId, Cargo = "Desenvolvedor Junior" },
                new PapelDto { Id = NovoId, Cargo = "Desenvolvedor Pleno" },
                new PapelDto { Id = NovoId, Cargo = "Desenvolvedor Senior" },
                new PapelDto { Id = NovoId, Cargo = "QA" },
                new PapelDto { Id = NovoId, Cargo = "Analista" },
            };

            Unidade = new List<UnidadeDto>
            {
                new UnidadeDto {
                    Id = NovoId,
                    Nome = "General Osorio",
                    Pais = "Brasil",
                    Estado = "SP",
                    Cidade = "Jundiai",
                    Bairro = "Centro",
                    Logradouro = "General Osorio",
                    Complemento = "",
                    Numero = 900,
                    Codigo_Postal = "321-400"  },

                new UnidadeDto {
                    Id = NovoId,
                    Nome = "Jobim",
                    Pais = "Brasil",
                    Estado = "SP",
                    Cidade = "Jundiai",
                    Bairro = "Anhangabau",
                    Logradouro = "Nove de Julho",
                    Complemento = "Edificio Jobim",
                    Numero = 110,
                    Codigo_Postal = "000-000"  },
            };

            Mentor = new List<MentorDto>
            {
                new MentorDto { Id = NovoId, Id_Pessoa = Pessoa[0].Id, NomePessoa = "Anderson" },
                new MentorDto { Id = NovoId, Id_Pessoa = Pessoa[1].Id, NomePessoa = "Rafaela" },
                new MentorDto { Id = NovoId, Id_Pessoa = Pessoa[2].Id, NomePessoa = "Ftato" },
            };
        }
    }
}