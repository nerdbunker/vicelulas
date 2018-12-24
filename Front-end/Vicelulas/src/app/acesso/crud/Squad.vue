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
            <td class="text-xs-right">{{ props.item.tribo }}</td>
            <td class="text-xs-right">{{ props.item.analista }}</td>
            <td class="text-xs-right">{{ props.item.qualidade }}</td>
            <td class="text-xs-right">{{ props.item.devteam }}</td>
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
        { text: 'Tribo', value: 'tribo' },
        { text: 'Analista/PO', value: 'analista' },
        { text: 'Qualidade', value: 'qualidade' },
        { text: 'Dev Team', value: 'devteam' },
        { text: 'Info', value: 'info' },
        { text: 'Editar', value: 'editar' },
        { text: 'Ativar/Desativar', value: 'desativar' }
      ],
      desserts: [
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          analista: 'Guilherme',
          qualidade: 'Aules',
          devteam: 'FM, GT, ED',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          analista: 'Guilherme',
          qualidade: 'Aules',
          devteam: 'FM, GT, ED',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        },
        {
          value: false,
          nome: 'Fernando',
          tribo: 'Consultoria',
          analista: 'Guilherme',
          qualidade: 'Aules',
          devteam: 'FM, GT, ED',
          info: 'info',
          editar: 'create',
          desativar: 'delete'
        }
      ]
    }
  }
}
</script>
