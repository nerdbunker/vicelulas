<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md10 xs12>
        <v-data-table
          :headers="headers"
          :items="desserts"
          class="elevation-1"
          dark
        >
          <template slot="items" slot-scope="props">
            <td>{{ props.item.nome }}</td>
            <td>{{ props.item.squads }}</td>
            <td>{{ props.item.pessoas }}</td>
            <td>{{ props.item.gestor }}</td>
            <td>
              <v-btn to="/editartribo" flat icon color="green">
                <v-icon flat>{{ props.item.editar }}</v-icon>
              </v-btn>
              <v-btn flat icon color="red">
                <v-icon>{{ props.item.desativar }}</v-icon>
              </v-btn>
            </td>
          </template>
        </v-data-table>
        <v-btn to="/inserirtribo" icon color="blue">
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
        { text: 'Squads', value: 'squads' },
        { text: 'Pessoas', value: 'pessoas' },
        { text: 'Gestor', value: 'gestor' },
        { text: 'Editar — Desativar', value: 'acoes' }
      ],
      desserts: [
        {
          value: false,
          nome: 'CDS MAPFRE',
          squads: 5,
          pessoas: 14,
          gestor: 'Rafaela',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS PRODUTOS',
          squads: 2,
          pessoas: 10,
          gestor: 'Fantatho',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS Viceri',
          squads: 4,
          pessoas: 30,
          gestor: 'Anderson',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS FINAMAX',
          squads: 2,
          pessoas: 10,
          gestor: 'Fantatho',
          editar: 'create',
          desativar: 'delete'
        }
      ]
    }
  }
}
</script>
