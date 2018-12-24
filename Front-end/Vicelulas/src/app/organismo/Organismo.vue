<template>
  <v-slide-y-transition mode="out-in">
    <v-container fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex pt-5 xs12>
          <v-chip color="green" text-color="white">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
            {{ msg }}
          </v-chip>
        </v-flex>
        <v-flex pt-3 md8 xs12>
          <Gestor />
          <v-flex
            v-for="(tribo, i) in tribos"
            :key="i"
            class="flex"
          >
            <router-link :to="tribo.to">
              <!-- SVG Dinamico, cria as imagens conforme a API fornece dados -->
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <!-- Imagem de Fundo - Célula -->
                <image :xlink:href="tribo.img" x="0" y="0" height="100%" width="100%"></image>
                <!-- Fundo do Texto -->
                <filter x="0" y="0" style="border-radius: 5px;" width="1" height="1" id="solid">
                  <feFlood flood-color="black"/>
                  <feComposite in="SourceGraphic"/>
                </filter>
                <!-- Titulo -->
                <text
                  x="50%" y="50%" class="fundo"
                  fill="white" filter="url(#solid)"
                  dominant-baseline="middle" text-anchor="middle"
                  font-size="100%"
                >
                  {{ tribo.name }}
                </text>
              </svg>
            </router-link>
          </v-flex>
        </v-flex>
        <Contador />
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
import Contador from '../componentes/Contador'
import Gestor from '../componentes/Gestor'

export default {
  name: 'Home',
  components: {
    Contador,
    Gestor
  },
  data () {
    return {
      msg: 'Tribos e Squads do Organismo Viceri',
      tribos: [
        { name: 'Consultoria', cor: 'blue', tipo: 'bubble_chart', to: '/tribos/consultoria', img: require('../../../static/icones/cell.png') },
        { name: 'Finamax', cor: 'purple', tipo: 'tribo', to: '/tribos/finamax', img: require('../../../static/icones/cell.png') },
        { name: 'Global Dev', cor: 'green', tipo: 'squad', to: '/tribos/globaldev', img: require('../../../static/icones/cell-blue.png') },
        { name: 'Viceri', cor: 'blue', tipo: 'tribo', to: '/tribos/globaldev', img: require('../../../static/icones/cell.png') },
        { name: 'I. Unibanco', cor: 'blue', tipo: 'tribo', to: '/tribos/unibanco', img: require('../../../static/icones/cell.png') },
        { name: 'MAPFRE', cor: 'purple', tipo: 'tribo', to: '/tribos/mapfre', img: require('../../../static/icones/cell.png') },
        { name: 'Passarela', cor: 'purple', tipo: 'tribo', to: '/tribos/passarela', img: require('../../../static/icones/cell.png') },
        { name: 'Produtos', cor: 'green', tipo: 'tribo', to: '/tribos/produtos', img: require('../../../static/icones/cell.png') },
        { name: 'Sequoia', cor: 'blue', tipo: 'squad', to: '/tribos/sequoia', img: require('../../../static/icones/cell-blue.png') }
      ]
    }
  }
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css?family=Kalam');

a {
  text-decoration: none;
  text-transform: uppercase;
}
.flex {
  display: inline;
  flex-wrap: wrap;

}
.zoom {
  padding: 15px;
  transition: transform .2s;
  width: 150px;
  height: 150px;
  margin: 0 auto;
}
.zoom:hover {
  transform: scale(1.3);
}
.fundo {
  font-family: 'Kalam', cursive;
  border-radius: 10px;
}
</style>
