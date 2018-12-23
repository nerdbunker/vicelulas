<template>
  <v-container fluid grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-timeline>
          <v-timeline-item
            v-for="(historico, n) in historicos"
            :key="n"
            color="red lighten-2"
            large
          >
            <span slot="opposite">{{ historico.data }}</span>
            <v-card class="elevation-2">
              <v-card-title class="headline">Alteração</v-card-title>
              <v-card-text>
                {{ historico.admin + ' moveu ' + historico.alterado + ' de ' + historico.anterior + ' para ' + historico.atual }}
              </v-card-text>
            </v-card>
          </v-timeline-item>
        </v-timeline>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Timeline',
  data () {
    return {
      historicos: [
        { data: '05/16', admin: 'Anderson', alterado: 'Marcelo', anterior: 'SQUAD1', atual: 'SQUAD5' },
        { data: '05/16', admin: 'Rafaela', alterado: 'Lucas', anterior: 'SQUAD13', atual: 'SQUAD7' },
        { data: '01/17', admin: 'Fantatho', alterado: 'Mateus', anterior: 'SQUAD15', atual: 'SQUAD9' },
        { data: '05/17', admin: 'Anderson', alterado: 'Rafael', anterior: 'SQUAD7', atual: 'SQUAD3' },
        { data: '05/18', admin: 'Rafaela', alterado: 'Felipe', anterior: 'SQUAD3', atual: 'SQUAD13' }
      ]
    }
  }
}
</script>
