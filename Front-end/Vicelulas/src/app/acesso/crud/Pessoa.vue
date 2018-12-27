<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-data-table
          :headers="headers"
          :items="pessoas"
          class="elevation-1"
          dark
        >
          <template slot="items" slot-scope="pessoas">
            <td>{{ items.nome }}</td>
            <td>{{ items.papel }}</td>
            <td>{{ items.squad }}</td>
            <td>{{ items.tribo }}</td>
            <!-- Ícone de Feedback
            <td>
              <v-btn flat icon color="cyan">
                <v-icon flat>{{ props.item.feedback }}</v-icon>
              </v-btn>
            </td>
            -->
            <td>
              <v-btn to="/editarpessoa" flat icon color="green">
                <v-icon flat>create</v-icon>
              </v-btn>
              <v-switch label="desativar" color="red" v-model="item.ativo"></v-switch>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirpessoa" color="blue">
          <v-icon>add</v-icon>
          Adicionar Pessoa
        </v-btn>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Pessoas from '../../../domains/services/Pessoas'

export default {
  name: 'Pessoa',
  data () {
    return {
      headers: [
        { text: 'Nome', align: 'left', sortable: true, value: 'nome' },
        { text: 'Papel', value: 'posicao_papel' },
        { text: 'Squad', value: 'squad' },
        { text: 'Tribo', value: 'tribo' },
        // { text: 'Feedback', value: 'feedback' },
        { text: 'Editar — Desativar', value: 'acoes' }
      ],
      pessoas: [],
      pessoasId: []
    }
  },
  mounted () {
    Pessoas.obterPessoa().then(respostaPessoa => {
      console.log(respostaPessoa)
      this.pessoas = respostaPessoa.data
    })
    Pessoas.obterPessoaPorId().then(respostaPessoaId => {
      console.log(respostaPessoaId)
      this.pessoasId = respostaPessoaId
    })
  }
}
</script>
