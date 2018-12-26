<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <Squads />
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Squads from './Squads'

export default {
  name: 'Tribos',
  components: {
    Squads
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
