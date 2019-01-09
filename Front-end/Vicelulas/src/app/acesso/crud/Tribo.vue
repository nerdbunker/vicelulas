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
            :items="listaTribos"
            class="elevation-1"
          >
            <template slot="items" slot-scope="props">
              <td>{{ props.item.nome }}</td>
              <td>{{ props.item.ativo?'Sim':'Não' }}</td>
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
              <v-btn color="primary" @click="initialize">Reiniciar</v-btn>
            </template>
          </v-data-table>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
import TribosAPI from '../../../domain/services/TribosAPI'

export default {
  data: () => ({
    dialog: false,
    listaTribos: [],
    headers: [
      {
        text: 'Nome',
        align: 'left',
        sortable: false,
        value: 'nome'
      },
      {
        text: 'Ativo?',
        align: 'left',
        sortable: true,
        value: 'ativo'
      },
      { text: 'Ações', value: 'nome' }
    ],
    editedIndex: -1,
    editedItem: {
      nome: '',
      ativo: true
    },
    defaultItem: {
      nome: '',
      ativo: true
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
      this.listaTribos = []
    },

    editItem (item) {
      // Alterar aqui o this.tribos
      this.editedIndex = this.listaTribos.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem (item) {
      const index = this.listaTribos.indexOf(item)
      confirm('Tem certeza que deseja desativar esta Pessoa?') &&
        this.listaTribos.splice(index, 1)
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
        Object.assign(this.listaTribos[this.editedIndex], this.editedItem)
        TribosAPI.alterarTribo(this.editedItem.id, this.editedItem)
      } else {
        this.listaTribos.push(this.editedItem)
        TribosAPI.inserirTribo(this.editedItem)
      }
      this.close()
    }
  },
  mounted () {
    TribosAPI.obterTribo().then(respostaTribo => {
      this.listaTribos = respostaTribo.data
    })
  }
}
</script>
