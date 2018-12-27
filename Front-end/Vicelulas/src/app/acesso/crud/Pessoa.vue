<template>
  <div id="pessoa">
    <v-container grid-list-xs>
      <v-layout row wrap>
        <v-flex md10 xs12>
          <v-toolbar flat dark>
            <v-toolbar-title>Tribo</v-toolbar-title>
            <v-divider class="mx-2" inset vertical></v-divider>
            <v-spacer></v-spacer>
            <v-dialog v-model="dialog" max-width="500px">
              <v-btn slot="activator" color="primary" dark class="mb-2">Nova Pessoa</v-btn>
              <v-card>
                <v-card-title>
                  <span class="headline">{{ formTitle }}</span>
                </v-card-title>

                <v-card-text>
                  <v-container grid-list-md>
                    <v-layout wrap>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="editedItem.nome" label="Nome Completo"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="editedItem.email" label="Email"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          :items="items"
                          v-model="editedItem.cargo"
                          label="Cargo"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          :items="items"
                          v-model="editedItem.unidade"
                          label="Unidade"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          :items="items"
                          v-model="editedItem.id_Squads"
                          label="Squad"
                        ></v-select>
                      </v-flex>
                    </v-layout>
                  </v-container>
                </v-card-text>

                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn color="blue darken-1" flat @click="close">Cancelar</v-btn>
                  <v-btn color="blue darken-1" flat @click="save">Salvar</v-btn>
                </v-card-actions>
              </v-card>
            </v-dialog>
          </v-toolbar>
          <v-data-table :headers="headers" :items="pessoas" class="elevation-1">
            <template slot="items" slot-scope="props">
              <td>{{ props.item.nome }}</td>
              <td class="text-xs-right">{{ props.item.email }}</td>
              <td class="text-xs-right">{{ props.item.cargo }}</td>
              <td class="text-xs-right">{{ props.item.id_Unidade }}</td>
              <td class="text-xs-right">{{ props.item.id_Squads }}</td>
              <td class="text-xs-right">{{ props.item.tribo }}</td>
              <td class="justify-center layout px-0">
                <v-icon small class="mr-2" @click="editItem(props.item)">edit</v-icon>
                <v-icon small @click="deleteItem(props.item)">delete</v-icon>
              </td>
            </template>
            <template slot="no-data">
              <v-btn color="primary" @click="initialize">Reset</v-btn>
            </template>
          </v-data-table>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
import Pessoas from '../../../domains/services/Pessoas'

export default {
  data: () => ({
    dialog: false,
    pessoas: [],
    headers: [
      {
        text: 'Nome',
        align: 'left',
        sortable: false,
        value: 'nome'
      },
      { text: 'Email', value: 'email' },
      { text: 'Cargo', value: 'cargo' },
      { text: 'Unidade', value: 'fat' },
      { text: 'Squad', value: 'carbs' },
      { text: 'Tribo', value: 'protein' },
      { text: 'Ações', value: 'nome' }
    ],
    editedIndex: -1,
    editedItem: {
      nome: '',
      email: '',
      cargo: '',
      unidade: '',
      squad: '',
      tribo: ''
    },
    defaultItem: {
      nome: '',
      email: '',
      cargo: '',
      unidade: '',
      squad: '',
      tribo: ''
    }
  }),

  computed: {
    formTitle () {
      return this.editedIndex === -1 ? 'Adicionar Pessoa' : 'Editar Pessoa'
    }
  },

  watch: {
    dialog (val) {
      val || this.close()
    }
  },

  created () {
    this.initialize()
  },

  methods: {
    initialize () {
      this.pessoas = []
    },

    editItem (item) {
      this.editedIndex = this.desserts.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem (item) {
      const index = this.desserts.indexOf(item)
      confirm('Tem certeza que deseja desativar esta Pessoa?') &&
        this.desserts.splice(index, 1)
    },

    close () {
      this.dialog = false
      setTimeout(() => {
        this.editedItem = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      }, 300)
    },

    save () {
      if (this.editedIndex > -1) {
        Object.assign(this.desserts[this.editedIndex], this.editedItem)
      } else {
        this.desserts.push(this.editedItem)
      }
      this.close()
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
