<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md5 xs10>
        <v-card>
          <Pesquisar />
        </v-card>
      </v-flex>
      <v-flex md8 xs12>
        <Squads />
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
