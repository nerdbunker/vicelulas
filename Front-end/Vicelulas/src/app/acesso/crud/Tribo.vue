<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-data-table
          :headers="headers"
          :items="tribos"
          class="elevation-1"
          dark
        >
          <template slot="items" slot-scope="tribos">
            <td>{{ items.tribos.nome }}</td>
            <td>{{ items.tribos.squads }}</td>
            <td>
              <v-btn to="/editartribo" flat icon color="green">
                <v-icon flat>create</v-icon>
              </v-btn>
              <v-switch label="desativar" color="red" v-model="items.tribos.ativo"></v-switch>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirtribo" color="blue">
          <v-icon>add</v-icon>
          Adicionar Tribo
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
        { text: 'Squads', value: 'squads' },
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
