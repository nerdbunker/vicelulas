<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-data-table
          :headers="headers"
          :items="desserts"
          class="elevation-1"
          dark
        >
          <template slot="items" slot-scope="props">
            <td>{{ props.item.nome }}</td>
            <td>{{ props.item.papel }}</td>
            <td>{{ props.item.squad }}</td>
            <td>{{ props.item.tribo }}</td>
            <td>
              <v-btn flat icon color="cyan">
                <v-icon flat>{{ props.item.feedback }}</v-icon>
              </v-btn>
              <v-btn flat icon color="green">
                <v-icon flat>{{ props.item.editar }}</v-icon>
              </v-btn>
              <v-btn flat icon color="red">
                <v-icon>{{ props.item.desativar }}</v-icon>
              </v-btn>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirpessoa" icon color="blue">
          <v-icon>add</v-icon>
        </v-btn>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Pessoa',
  data () {
    return {
      headers: [
        {
          text: 'Nome',
          align: 'left',
          sortable: true,
          value: 'nome'
        },
        { text: 'Papel', value: 'posicao_papel' },
        { text: 'Squad', value: 'squad' },
        { text: 'Tribo', value: 'tribo' },
        { text: 'Feedback/Editar/Desativar', value: 'acoes' }
      ],
      desserts: [
        {
          value: false,
          nome: 'Fernando',
          papel: 'Arquiteto Back-end',
          squad: 'Tech',
          tribo: 'Consultoria',
          feedback: 'feedback',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernanda',
          papel: 'Arquiteto de Testes',
          squad: 'Tech',
          tribo: 'Consultoria',
          feedback: 'feedback',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Paulo',
          papel: 'UX Senior',
          squad: 'Tech',
          tribo: 'Consultoria',
          feedback: 'feedback',
          editar: 'create',
          desativar: 'delete'
        }
      ]
    }
  }
}
</script>
