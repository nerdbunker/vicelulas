<template>
  <div id="squads">
    <v-layout row wrap pt-3 justify-center align-content-center>
      <v-flex
        v-for="(squad, i) in squads"
        :key="i"
        xs12 md6
      >
        <!-- Card da Squad -->
        <v-card dark>
            <v-card-title primary-title>
              <v-flex md5 xs12>
                <v-img
                  justify-center
                  :src="img"
                  height="125px"
                  contain
                ></v-img>
              </v-flex>
              <v-spacer></v-spacer>
              <div class="squad-text">
                <div class="headline">{{ squad.nome }}</div>
                <!-- <div>Analista: {{ squad.analista }}</div>
                <div>Qualidade: {{ squad.qualidade }}</div>
                <div>Dev Team: {{ squad.time }}</div> -->
              </div>
            </v-card-title>
          <v-divider light></v-divider>
          <v-card-actions class="pa-3">
            Tribo: {{ squad.nomeTribo }}
            <v-spacer></v-spacer>
            <!-- Mentor: {{ squad.gestor }} -->
          </v-card-actions>
        </v-card>
      </v-flex>
      <v-flex xs12 pb-5></v-flex>
    </v-layout>
  </div>
</template>

<script>
import Squads from '../../domain/services/Squads'

export default {
  name: 'Squads',
  data () {
    return {
      img: require('../../../static/icones/viceri.png'),
      squads: []
    }
  },
  mounted () {
    Squads.obterSquadPorIdTribo(this.$route.params.id).then(resposta => {
      console.log(resposta)
      this.squads = resposta.data
    })
  }
}
</script>

<style>
/* .squad-text {
  text-align: left;
} */
</style>
