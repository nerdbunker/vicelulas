<template>
  <v-container fluid grid-list-xs text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12 elevation-10>
        <v-expansion-panel dark>
          <v-expansion-panel-content
            v-for="(item,i) in items"
            :key="i"
          >
            <div slot="header">{{ item.title }}</div>
            <v-card>
              <v-card-text>{{ item.text }}</v-card-text>
            </v-card>
          </v-expansion-panel-content>
        </v-expansion-panel>
      </v-flex>
      <v-flex xs12 pb-5></v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Duvidas',
  data () {
    return {
      items: [
        {
          title: 'O que é o Organismo Viceri?',
          text: '— Organismo Viceri é uma solução digital para uma visão completa da nossa estrutura organica que está em constante evolução.'
        },
        {
          title: 'Como utilizar?',
          text: '— Acesse a página inicial que é o item "Organismo" da barra lateral, então clique sobre a tribo, squad ou gestor localizado no mapa do organismo.'
        },
        {
          title: 'Como resolvo um Problema?',
          text: '— Na barra de links Laterais tem o link "Suporte" que leva para uma página de apoio.'
        },
        {
          title: 'Como fixar/adicionar o Vicelulas na tela inicial?',
          text: '— Em seu navegador, abra o menu e procure a opção "Fixar no Inicio" ou "Adicionar na Tela Inicial"'
        },
        {
          title: 'O que significa cada nomeclatura?',
          text: '— Dentro do organismo Viceri, uma Tribo é um conjunto de Squads que tem o mesmo cliente como objetivo, e o Squad é a célula formada por Analistas, QA`s e Devs. Um Squad não precisa necessariamente estar em uma tribo, mas tribos só são formadas por vários Squads em comum.'
        },
        {
          title: 'O que é uma Tribo?',
          text: '— Uma Tribo é um conjunto de 2 ou mais Squads.'
        },
        {
          title: 'O que é uma Squad?',
          text: '— É um time autonomo, uma célula de desenvolvimento que possui 1 Analista (Que pode agir como PO e/ou Scrum Master), 1 QA, e o Dev Team (que pode ser formado por 1, 2, ou mais desenvolvedores — o Padrão costuma ser 1 Dev Senior + 1 Dev Pleno + 1 Dev Junior/Treinee/Estagiário)'
        },
        {
          title: 'O que é o PO, Scrum Master, Dev Team?',
          text: '— No Ágil o PO ou Product Owner é um integrante da equipe responsável pelo negócio (regras de negócio, Product Backlog, etc... ver Scrum Guide para maiores informações).'
        },
        {
          title: 'O que é o Scrum Master?',
          text: '— O Scrum Master é um facilitador, ele trabalha para remover os impedimentos da equipe referente ao desenvolvimento, cuidando para que o cronograma seja respeitado e seguido sem impedimentos.'
        },
        {
          title: 'O que é o Dev Team?',
          text: '— O Dev Team é o time de desenvolvimento, que faz parte de uma Squad, que pode ser formado por 1, 2, ou mais desenvolvedores, o Padrão costuma ser 1 Dev Senior + 1 Dev Pleno + 1 Dev Junior/Treinee/Estagiário'
        }
      ]
    }
  }
}
</script>
