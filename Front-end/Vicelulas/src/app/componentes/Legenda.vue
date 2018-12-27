<template>
  <v-layout justify-center align-content-center>
    <v-flex
      v-for="(tribo, i) in tribos"
      :key="i"
      class="flex" xs6
    >
      <!-- SVG Dinamico, cria as imagens conforme a API fornece dados -->
      <svg class="zoom" height="65px" width="65px" xmlns="http://www.w3.org/2000/svg">
        <!-- Imagem de Fundo - Célula -->
        <image :xlink:href="tribo.img" x="0" y="0" :alt="tribo.desc" height="100%" width="100%"></image>
        <!-- Titulo -->
        <text
          x="50%" y="50%" class="legenda"
          fill="black"
          dominant-baseline="middle" text-anchor="middle"
          font-size="100%"
        >
          {{ tribo.nome }}
        </text>
      </svg>
    </v-flex>
  </v-layout>
</template>

<script>
export default {
  name: 'Gestor',
  data () {
    return {
      tribos: [
        { nome: 'Tribo', desc: 'Imagem Indicativa da Tribo', img: require('../../../static/icones/cell.png') },
        { nome: 'Squad', desc: 'Imagem Indicativa da Squad', img: require('../../../static/icones/cell-blue.png') }
      ]
    }
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css?family=Kalam:700');

.legenda {
  font-family: 'Kalam', coursive;
  width: 20%;
}
.flex {
  display: inline;
  flex-wrap: wrap;
}
</style>
