<template>
  <v-slide-y-transition mode="out-in">
    <v-container class="celulaSvg" fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex xs4 mb-5 pa-1>
          <v-card class="search">
            <v-text-field
              color="green"
              v-model="search"
              append-icon="search"
              label="Search"
              single-line
              hide-details
            ></v-text-field>
          </v-card>
        </v-flex>
        <v-flex xs10>
          <div class="flex">
            <router-link to="/tribos/brinks"><img :src="brinks" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/consultoria"><img :src="consultoria" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/finamax"><img :src="finamax" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/globaldev"><img :src="globaldev" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/unibanco"><img :src="unibanco" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/mapfre"><img :src="mapfre" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/passarela"><img :src="passarela" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/produtos"><img :src="produtos" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <router-link to="/tribos/sequoia"><img :src="sequoia" alt="" class="animate"></router-link>
          </div>
          <div class="flex">
            <img :src="anderson" alt="Anderson - Gestor (Gerente)" class="animate">
          </div>
          <div class="flex">
            <img :src="fantatho" alt="Fantatho - Gestor (Coordenador)" class="animate">
          </div>
          <div class="flex">
            <img :src="rafaela" alt="Rafaela - Gestora (Coordenadora)" class="animate">
          </div>
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
      // Imagens - Gestores, Tribos e Squads
      anderson: require('../../static/organismo/anderson.png'),
      fantatho: require('../../static/organismo/fantatho.png'),
      rafaela: require('../../static/organismo/rafaela.png'),
      brinks: require('../../static/organismo/brinks.png'),
      consultoria: require('../../static/organismo/consultoria.png'),
      finamax: require('../../static/organismo/finamax.png'),
      globaldev: require('../../static/organismo/global.png'),
      unibanco: require('../../static/organismo/iu.png'),
      mapfre: require('../../static/organismo/mapfre.png'),
      passarela: require('../../static/organismo/passarela.png'),
      produtos: require('../../static/organismo/produtos.png'),
      sequoia: require('../../static/organismo/sequoia.png')
    }
  }
}
</script>



<style scoped>
.celulaSvg {
  background-image: url('../../static/imagens/bg.svg');
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
.animate {
  animation-name: girando;
  animation-duration: 300s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
}

@keyframes girando {
  from {
  transform: rotate(0deg);
}
  to {
    transform: rotate(360deg);
  }
}
</style>
