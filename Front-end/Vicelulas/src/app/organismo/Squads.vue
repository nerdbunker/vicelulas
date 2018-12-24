<template>
  <div id="squads">
    <v-layout row wrap pt-3>
      <v-flex
        v-for="(squad, i) in squads"
        :key="i"
        xs12 md6
      >
        <!-- Card da Squad -->
        <v-card dark>
            <v-card-title primary-title>
              <v-flex md6 xs12>
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
          <v-divider light></v-divider>
          <v-card-actions class="pa-3">
            Tribo: {{ squad.tribo }} | Gestor: {{ squad.gestor }}
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
        { nome: 'SQUAD First', gestor: 'Anderson', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/avatar-viceri.png') },
        { nome: 'SQUAD Lightning', gestor: 'Rafaela', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/avatar-viceri.png') },
        { nome: 'SQUAD Lightning', gestor: 'Rafaela', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/avatar-viceri.png') },
        { nome: 'SQUAD Master', gestor: 'Fantatho', tribo: 'Mapfre', analista: 'Ricardo', qualidade: 'Ana Paula', time: 'Marcos, Luis, Jose', img: require('../../../static/icones/avatar-viceri.png') }
      ]
    }
  }
}
</script>

<style>
.squad-text {
  text-align: left;
}
</style>
