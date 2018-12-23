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
            <td class="text-xs-right">{{ props.item.posicao_papel }}</td>
            <td class="text-xs-right">{{ props.item.squad }}</td>
            <td class="text-xs-right">{{ props.item.tribo }}</td>
            <td class="text-xs-right">
              <v-btn flat icon color="cyan">
                <v-icon flat>{{ props.item.feedback }}</v-icon>
              </v-btn>
            </td>
            <td class="text-xs-right">
              <v-btn flat icon color="green">
                <v-icon flat>{{ props.item.editar }}</v-icon>
              </v-btn>
            </td>
            <td class="text-xs-right">
              <v-btn flat icon color="green">
                <v-icon>{{ props.item.desativar }}</v-icon>
              </v-btn>
            </td>
          </template>
        </v-data-table>
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
        { text: 'Posição/Papel', value: 'posicao_papel' },
        { text: 'Squad', value: 'squad' },
        { text: 'Tribo', value: 'tribo' },
        { text: 'Feedback', value: 'feedback' },
        { text: 'Editar', value: 'editar' },
        { text: 'Desativar', value: 'desativar' }
      ],
      desserts: [
        {
          value: false,
          nome: 'Fernando',
          posicao_papel: 'Arquiteto Back-end',
          squad: 'Tech',
          tribo: 'Consultoria',
          feedback: 'feedback',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernanda',
          posicao_papel: 'Arquiteto de Testes',
          squad: 'Tech',
          tribo: 'Consultoria',
          feedback: 'feedback',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Paulo',
          posicao_papel: 'UX Senior',
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
