<template>
  <v-container fluid grid-list-xs text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12 elevation-10>
        <v-expansion-panel>
          <v-expansion-panel-content
            v-for="(item,i) in items"
            :key="i"
          >
            <div slot="header">{{ item.title }}</div>
            <v-card>
              <v-card-text class="grey lighten-3">{{ item.text }}</v-card-text>
            </v-card>
          </v-expansion-panel-content>
        </v-expansion-panel>
      </v-flex>
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
          text: 'Organismo Viceri é uma solução digital para uma visão completa da nossa estrutura organica que está em constante evolução.'
        },
        {
          title: 'Como utilizar?',
          text: 'Acesse a página inicial que é o item "Organismo" da barra lateral, então clique sobre a tribo, squad ou gestor localizado no mapa do organismo.'
        },
        {
          title: 'Como resolvo um Problema?',
          text: 'Na barra de links Laterais tem o link "Suporte" que leva para uma página de apoio.'
        },
        {
          title: 'O que significa cada nomeclatura?',
          text: 'Dentro do organismo Viceri, uma Tribo é um conjunto de Squads que tem o mesmo cliente como objetivo, e o Squad é a célula formada por Analistas, QA`s e Devs. Um Squad não precisa necessariamente estar em uma tribo, mas tribos só são formadas por vários Squads em comum.'
        },
        {
          title: 'Como fixar/adicionar o Vicelulas na tela inicial?',
          text: 'Em seu navegador, abra o menu e procure a opção "Fixar no Inicio" ou "Adicionar na Tela Inicial"'
        }
      ]
    }
  }
}
</script>
