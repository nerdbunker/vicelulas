<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md10 xs12>
        <v-data-table
          :headers="headers"
          :items="desserts"
          class="elevation-1"
          dark centered
        >
          <template slot="items" slot-scope="props">
            <td>{{ props.item.nome }}</td>
            <td>{{ props.item.tribo }}</td>
            <td>{{ props.item.pessoas }}</td>
            <td>
              <v-btn to="/editarsquad" flat icon color="green">
                <v-icon flat>{{ props.item.editar }}</v-icon>
              </v-btn>
              <v-btn flat icon color="red">
                <v-icon>{{ props.item.desativar }}</v-icon>
              </v-btn>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirsquad" icon color="blue">
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
      dialog: false,
      headers: [
        {
          text: 'Nome',
          align: 'left',
          sortable: true,
          value: 'nome'
        },
        { text: 'Tribo', value: 'tribo' },
        { text: 'Pessoas', value: 'pessoas' },
        { text: 'Editar — Desativar', value: 'acoes' }
      ],
      desserts: [
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          pessoas: 'Todas os nomes aqui',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          pessoas: 'Todas os nomes aqui',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          pessoas: 'Todas os nomes aqui',
          editar: 'create',
          desativar: 'delete'
        }
      ]
    }
  }
}
</script>
