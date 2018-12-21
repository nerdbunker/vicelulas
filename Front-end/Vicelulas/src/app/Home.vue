<template>
  <v-slide-y-transition mode="out-in">
    <v-container class="celulaSvg" fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex md5 xs12 mb-5 pa-1>
          <v-card class="search">
            <v-text-field
              color="green"
              v-model="search"
              append-icon="search"
              label="Pesquisar"
              single-line
              hide-details
            ></v-text-field>
          </v-card>
        </v-flex>
        <v-flex xs12>
          <v-flex
            v-for="(tribo, i) in tribos"
            :key="i"
            class="flex"
          >
            <router-link :to="tribo.to">
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <image xlink:href="../../static/icones/celula.png"
                       x="0" y="0" height="100%" width="100%"></image>
                <text x="50%" y="50%"
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
      name: 'qq coisa',
      tribos: [
        // Imagens - Gestores, Tribos e Squads
        { name: 'Anderson', to: '/tribos/anderson', img: require('../../static/organismo/anderson.png') },
        { name: 'Fantatho', to: '/tribos/fantatho', img: require('../../static/organismo/fantatho.png') },
        { name: 'Rafaela', to: '/tribos/rafaela', img: require('../../static/organismo/rafaela.png') },
        { name: 'Brinks', to: '/tribos/brinks', img: require('../../static/organismo/brinks.png') },
        { name: 'Consultoria', to: '/tribos/consultoria', img: require('../../static/organismo/consultoria.png') },
        { name: 'Finamax', to: '/tribos/finamax', img: require('../../static/organismo/finamax.png') },
        { name: 'Global Dev', to: '/tribos/globaldev', img: require('../../static/organismo/global.png') },
        { name: 'I. Unibanco', to: '/tribos/unibanco', img: require('../../static/organismo/iu.png') },
        { name: 'MAPFRE', to: '/tribos/mapfre', img: require('../../static/organismo/mapfre.png') },
        { name: 'Passarela', to: '/tribos/passarela', img: require('../../static/organismo/passarela.png') },
        { name: 'Produtos', to: '/tribos/produtos', img: require('../../static/organismo/produtos.png') },
        { name: 'Sequoia', to: '/tribos/sequoia', img: require('../../static/organismo/sequoia.png') }
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
</style>
