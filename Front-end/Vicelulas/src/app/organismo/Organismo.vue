<template>
  <v-slide-y-transition mode="out-in">
    <v-container class="celulaSvg" fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex xs12>
          <v-chip color="purple" text-color="white">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
            Você está visualizando o organismo da Viceri.
          </v-chip>
        </v-flex>
        <v-flex xs7>
          <v-flex
            v-for="(tribo, i) in tribos"
            :key="i"
            class="flex"
          >
            <router-link :to="tribo.to">
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <!-- Imagem de Fundo - Atomo girando -->
                <image xlink:href="../../../static/icones/celula.png"
                       x="0" y="0" height="100%" width="100%"></image>
                <!-- Fundo do Texto -->
                <filter x="0" y="0" width="1" height="1" id="solid">
                  <feFlood flood-color="teal"/>
                  <feComposite in="SourceGraphic"/>
                </filter>
                <!-- Texto -->
                <text
                  x="50%" y="50%"
                  fill="white"
                  filter="url(#solid)"
                  dominant-baseline="middle" text-anchor="middle"
                  font-size="15">
                  {{ tribo.name }}
                </text>
              </svg>
            </router-link>
          </v-flex>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
export default {
  name: 'Home',
  data () {
    return {
      tribos: [
        // Imagens - Gestores, Tribos e Squads
        { name: 'Rafaela', to: '/tribos/brinks', img: require('../../../static/organismo/brinks.png') },
        { name: 'Anderson', to: '/tribos/brinks', img: require('../../../static/organismo/brinks.png') },
        { name: 'Fantatho', to: '/tribos/brinks', img: require('../../../static/organismo/brinks.png') },
        { name: 'Consultoria', to: '/tribos/consultoria', img: require('../../../static/organismo/consultoria.png') },
        { name: 'Finamax', to: '/tribos/finamax', img: require('../../../static/organismo/finamax.png') },
        { name: 'Global Dev', to: '/tribos/globaldev', img: require('../../../static/organismo/global.png') },
        { name: 'I. Unibanco', to: '/tribos/unibanco', img: require('../../../static/organismo/iu.png') },
        { name: 'MAPFRE', to: '/tribos/mapfre', img: require('../../../static/organismo/mapfre.png') },
        { name: 'Passarela', to: '/tribos/passarela', img: require('../../../static/organismo/passarela.png') },
        { name: 'Produtos', to: '/tribos/produtos', img: require('../../../static/organismo/produtos.png') },
        { name: 'Sequoia', to: '/tribos/sequoia', img: require('../../../static/organismo/sequoia.png') }
      ]
    }
  }
}
</script>

<style scoped>
a {
  text-decoration: none;
  text-transform: uppercase;
}
.flex {
  display: inline;
  flex-wrap: wrap;
}
.espaco {
  padding: 10px;
}
.search {
  padding-right: 5px;
  padding-left: 5px;
  padding-bottom: 10px;
}
.zoom {
  padding: 15px;
  transition: transform .2s;
  width: 150px;
  height: 150px;
  margin: 0 auto;
}
.zoom:hover {
  transform: scale(1.5);
}
.borda {
  border-radius: 10px;
}
</style>
