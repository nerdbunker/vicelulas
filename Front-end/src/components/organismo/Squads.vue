<template>
  <v-slide-y-transition mode="out-in">
    <v-container fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex xs4 mb-5 pa-1>
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
        <v-flex xs10>
          <v-card light class="espaco" elevation-20>
            <div class="flex">
              <router-link to="/tribos/squads/1"><img :src="consultoria" alt=""></router-link>
            </div>
            <div class="flex">
              <router-link to="tribos/squads/2"><img :src="unibanco" alt=""></router-link>
            </div>
            <div class="flex">
              <router-link to="tribos/squads/3"><img :src="sequoia" alt=""></router-link>
            </div>
            <div class="flex">
              <router-link to="tribos/squads/4"><img :src="produtos" alt=""></router-link>
            </div>
            <!-- <div class="flex">
              <img :src="anderson" alt="Anderson - Gestor (Gerente)">
            </div>
            <div class="flex">
              <img :src="fantatho" alt="Fantatho - Gestor (Coordenador)">
            </div> -->
          </v-card>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
export default {
  name: 'Tribos',
  data () {
    return {
      // Imagens - Gestores, Tribos e Squads
      anderson: require('../../../static/organismo/anderson.png'),
      fantatho: require('../../../static/organismo/fantatho.png'),
      rafaela: require('../../../static/organismo/rafaela.png'),
      brinks: require('../../../static/organismo/brinks.png'),
      consultoria: require('../../../static/organismo/consultoria.png'),
      finamax: require('../../../static/organismo/finamax.png'),
      globaldev: require('../../../static/organismo/global.png'),
      unibanco: require('../../../static/organismo/iu.png'),
      mapfre: require('../../../static/organismo/mapfre.png'),
      passarela: require('../../../static/organismo/passarela.png'),
      produtos: require('../../../static/organismo/produtos.png'),
      sequoia: require('../../../static/organismo/sequoia.png')
    }
  }
}
</script>



<style scoped>
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
</style>
