<template>
  <v-container fluid grid-list-xs text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex pb-5 xs12>
        <v-chip color="cinza" text-color="white">
          <v-avatar>
            <v-icon>bubble_chart</v-icon>
          </v-avatar>
          {{ legenda }}
        </v-chip>
      </v-flex>
      <v-flex md10 xs12>
        <v-timeline>
          <v-timeline-item
            v-for="(historico, n) in historicos"
            :key="n"
            color="green"
            large
          >
            <span slot="opposite">{{ historico.data }}</span>
            <v-card dark elevation-2>
              <v-card-title class="headline">{{ historico.tipo }}</v-card-title>
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
      legenda: 'Histórico de Alterações - [Não Implementado Ainda]',
      historicos: [
        { data: '04/05/2017', tipo: 'Alteração de Squad', admin: 'Anderson', alterado: 'Marcelo', anterior: 'SQUAD1', atual: 'SQUAD5' },
        { data: '05/05/2017', tipo: 'Alteração de Tribo', admin: 'Anderson', alterado: 'Marcelo', anterior: 'SQUAD1', atual: 'SQUAD5' },
        { data: '05/06/2018', tipo: 'Alteração de Squad', admin: 'Rafaela', alterado: 'Lucas', anterior: 'SQUAD13', atual: 'SQUAD7' },
        { data: '01/07/2018', tipo: 'Alteração de Tribo', admin: 'Fantatho', alterado: 'Mateus', anterior: 'SQUAD15', atual: 'SQUAD9' },
        { data: '05/10/2018', tipo: 'Alteração de Squad', admin: 'Anderson', alterado: 'Rafael', anterior: 'SQUAD7', atual: 'SQUAD3' },
        { data: '05/12/2018', tipo: 'Alteração de Squad', admin: 'Rafaela', alterado: 'Felipe', anterior: 'SQUAD3', atual: 'SQUAD13' }
      ]
    }
  }
}
</script>
