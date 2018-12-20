<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md5 xs10 mb-6 pa-1>
        <v-card class="search">
          <v-text-field
            color="teal"
            v-model="search"
            append-icon="search"
            label="Pesquisar"
            single-line
            hide-details
          ></v-text-field>
        </v-card>
      </v-flex>
      <v-flex md10 xs12>
        <v-flex>
          <h2>Tribo: {{ $route.params.name.toUpperCase() }}</h2>
          <h3>Squads</h3>
        </v-flex>
        <v-card class="espaco">
          <v-flex>
            <router-link :to="{name: 'Squad', params:{id:squads[0].id}}"><img :src="squads[0].img" alt="" ></router-link>
            <div><p> <b>P.O:</b> Mateus - <b>QA:</b> Lucas - <b>Dev:</b> Isac - <b>Dev:</b> Fernando - <b>Dev:</b> Pedro</p></div>
          </v-flex>
        </v-card>
        <v-card class="espaco">
          <v-flex>
            <router-link :to="{name: 'Squad', params:{id:squads[1].id}}"><img :src="squads[1].img" alt="" ></router-link>
            <div><p> <b>P.O:</b> Mateus - <b>QA:</b> Lucas - <b>Dev:</b> Isac - <b>Dev:</b> Fernando - <b>Dev:</b> Pedro</p></div>
          </v-flex>
        </v-card>
        <v-card class="espaco">
          <v-flex>
            <router-link :to="{name: 'Squad', params:{id:squads[2].id}}"><img :src="squads[2].img" alt="" ></router-link>
            <div><p><b>P.O:</b> Mateus - <b>QA:</b> Lucas - <b>Dev:</b> Isac - <b>Dev:</b> Fernando - <b>Dev:</b> Pedro</p></div>
          </v-flex>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Squads',
  data () {
    return {
      // Imagens - Squads
      squads: [
        { id: 1, img: require('../../../static/icones/squad1.png') },
        { id: 2, img: require('../../../static/icones/squad2.png') },
        { id: 3, img: require('../../../static/icones/squad3.png') }
      ]
      // tribos/"+$route.params.name+"/squad1
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
p {
  font-size: 18px;
  padding-top: 15px;
}
</style>
