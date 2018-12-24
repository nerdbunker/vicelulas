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
            <td class="text-xs-right">{{ props.item.squads }}</td>
            <td class="text-xs-right">{{ props.item.pessoas }}</td>
            <td class="text-xs-right">{{ props.item.gestor }}</td>
            <td class="text-xs-right">{{ props.item.cliente }}</td>
            <td class="text-xs-right">
              <v-btn flat icon color="cyan">
                <v-icon flat>{{ props.item.info }}</v-icon>
              </v-btn>
            </td>
            <td class="text-xs-right">
              <v-btn flat icon color="green">
                <v-icon flat>{{ props.item.editar }}</v-icon>
              </v-btn>
            </td>
            <td class="text-xs-right">
              <v-btn flat icon color="red">
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
        { text: 'Squads', value: 'squads' },
        { text: 'Pessoas', value: 'pessoas' },
        { text: 'Gestor', value: 'gestor' },
        { text: 'Cliente', value: 'cliente' },
        { text: 'Info', value: 'info' },
        { text: 'Editar', value: 'editar' },
        { text: 'Desativar', value: 'desativar' }
      ],
      desserts: [
        {
          value: false,
          nome: 'CDS MAPFRE',
          squads: 5,
          pessoas: 14,
          gestor: 'Rafaela',
          cliente: 'Mapfre',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS PRODUTOS',
          squads: 2,
          pessoas: 10,
          gestor: 'Fantatho',
          cliente: 'Varios',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS Viceri',
          squads: 4,
          pessoas: 30,
          gestor: 'Anderson',
          cliente: 'Varios',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'CDS FINAMAX',
          squads: 2,
          pessoas: 10,
          gestor: 'Fantatho',
          cliente: 'Finamax',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        }
      ]
    }
  }
}
</script>
