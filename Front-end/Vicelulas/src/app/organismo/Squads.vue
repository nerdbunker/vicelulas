<template>
  <div id="squads">
    <v-layout row wrap pa-2>
      <v-flex
        v-for="(squad, i) in squads"
        :key="i"
        xs12
      >
        <!-- Card da Squad -->
        <v-card color="blue darken-2" class="white--text">
          <v-flex xs12>
            <v-card-title primary-title>
              <v-flex xs5>
                <v-img
                  :src="squad.img"
                  height="125px"
                  contain
                ></v-img>
              </v-flex>
              <v-spacer></v-spacer>
              <div class="squad-text">
                <div class="headline">{{ squad.nome }}</div>
                <div>Analista: {{ squad.analista }}</div>
                <div>Qualidade: {{ squad.qualidade }}</div>
                <div>Dev Team: {{ squad.time }}</div>
              </div>
            </v-card-title>
          </v-flex>
          <v-divider light></v-divider>
          <v-card-actions class="pa-3">
            Esta Squad pertence à Tribo: {{ squad.tribo }}
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </div>
</template>

<script>
export default {
  name: 'Squads',
  data () {
    return {
      squads: [
        { nome: 'SQUAD First', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/team.png') },
        { nome: 'SQUAD Lightning', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/team.png') },
        { nome: 'SQUAD Master', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/team.png') }
      ]
    }
  }
}
</script>

<style>
.squad-text {
  text-align: left;
}
.imagem-time {
  width: 100%;
}
</style>
