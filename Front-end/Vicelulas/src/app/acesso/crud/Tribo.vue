<template>
  <div id="pessoa">
    <v-container grid-list-xs>
      <v-layout row wrap>
        <v-flex md10 xs12>
          <v-toolbar flat dark>
            <v-toolbar-title>TRIBOS</v-toolbar-title>
            <v-divider class="mx-2" inset vertical></v-divider>
            <v-spacer></v-spacer>
            <v-dialog v-model="dialog" max-width="500px">
              <v-btn slot="activator" color="primary" dark class="mb-2">Nova Tribo</v-btn>
              <v-card>
                <v-card-title>
                  <span class="headline">{{ formTitle }}</span>
                </v-card-title>

                <v-card-text>
                  <v-container grid-list-md>
                    <v-layout wrap>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="editedItem.nome" label="Nome da Tribo"></v-text-field>
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
          <v-data-table
            :headers="headers"
            :items="tribos"
            class="elevation-1"
          >
            <template slot="items" slot-scope="props">
              <td>{{ props.item.nome }}</td>
              <td>
              <v-icon
                small
                class="mr-2"
                @click="editItem(props.item)"
              >
                edit
              </v-icon>
              <v-icon
                small
                @click="deleteItem(props.item)"
              >
                delete
              </v-icon>
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
import Tribos from '../../../domain/services/Tribos'

export default {
  data: () => ({
    dialog: false,
    tribos: [],
    headers: [
      {
        text: 'Nome',
        align: 'left',
        sortable: false,
        value: 'nome'
      },
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
      return this.editedIndex === -1 ? 'Adicionar Tribo' : 'Editar Tribo'
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
      this.tribos = []
    },

    editItem (item) {
      // Alterar aqui o this.tribos
      this.editedIndex = this.tribos.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem (item) {
      const index = this.tribos.indexOf(item)
      confirm('Tem certeza que deseja desativar esta Pessoa?') &&
        this.tribos.splice(index, 1)
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
        Object.assign(this.tribos[this.editedIndex], this.editedItem)
      } else {
        this.tribos.push(this.editedItem)
      }
      this.close()
    }
  },
  mounted () {
    Tribos.obterTribo().then(respostaTribo => {
      console.log(respostaTribo)
      this.tribos = respostaTribo.data
    })
    Tribos.obterPessoaPorId().then(respostaPessoaId => {
      console.log(respostaPessoaId)
      this.tribosId = respostaPessoaId
    })
  }
}
</script>
