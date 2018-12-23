<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md5 xs12 mb-6 pa-1>
        <v-card>
          <Pesquisar />
          <v-divider></v-divider>
          <Squads />
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Pesquisar from '../componentes/Pesquisar'
import Squads from './Squads'

export default {
  name: 'Squad',
  components: {
    Squads,
    Pesquisar
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
</style>
