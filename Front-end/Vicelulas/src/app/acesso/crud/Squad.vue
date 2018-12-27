<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-data-table
          :headers="headers"
          :items="squads"
          class="elevation-1"
          dark centered
        >
          <template slot="items" slot-scope="squads">
            <td>{{ items.squads.nome }}</td>
            <td>{{ items.squads.tribo }}</td>
            <td>{{ items.squads.squad }}</td>
            <td>
              <v-btn to="/editarsquad" flat icon color="green">
                <v-icon flat>create</v-icon>
              </v-btn>
              <v-btn flat icon color="red">
                <v-icon>delete</v-icon>
              </v-btn>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirsquad" color="blue">
          <v-icon>add</v-icon>
          Adicionar Squad
        </v-btn>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Pessoas from '../../../domains/services/Pessoas'
import Tribos from '../../../domains/services/Tribos'
import Squads from '../../../domains/services/Squads'

export default {
  name: 'Pessoa',
  data () {
    return {
      headers: [
        { text: 'Nome', align: 'left', sortable: true, value: 'nome' },
        { text: 'Tribo', value: 'tribo' },
        { text: 'Editar — Desativar', value: 'acoes' }
      ],
      pessoas: [],
      tribos: [],
      squads: []
    }
  },
  mounted () {
    Pessoas.obterPessoa().then(respostaPessoa => {
      console.log(respostaPessoa)
      this.pessoas = respostaPessoa.data
    })
    Tribos.obterTribo().then(respostaTribo => {
      console.log(respostaTribo)
      this.pessoas = respostaTribo.data
    })
    Squads.obterSquad().then(respostaSquad => {
      console.log(respostaSquad)
      this.squads = respostaSquad.data
    })
  }
}
</script>
