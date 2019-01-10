<template>
  <div id="pessoa">
    <v-container grid-list-xs>
      <v-layout row wrap>
        <v-flex md10 xs12>
          <v-toolbar flat dark>
            <v-toolbar-title>SQUADS</v-toolbar-title>
            <v-divider class="mx-2" inset vertical></v-divider>
            <v-spacer></v-spacer>
            <v-dialog v-model="dialog" max-width="500px">
              <v-btn slot="activator" color="primary" dark class="mb-2">Nova Squad</v-btn>
              <v-card>
                <v-card-title>
                  <span class="headline">{{ formTitle }}</span>
                </v-card-title>

                <v-card-text>
                  <v-container grid-list-md>
                    <v-layout wrap>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="squadInsert.nome" label="Nome da Squad"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="nome"
                          item-value="id"
                          :items="listaTribos"
                          v-model="squadInsert.id_Tribo"
                          label="Tribo"
                        ></v-select>
                      </v-flex>
                    </v-layout>
                  </v-container>
                </v-card-text>

                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn color="blue darken-1" flat @click="close">Cancelar</v-btn>
                  <v-btn color="blue darken-1" v-show="squadInsert.nome && squadInsert.id_Tribo" flat @click="save">Salvar</v-btn>
                </v-card-actions>
              </v-card>
            </v-dialog>
          </v-toolbar>
          <v-data-table
            :headers="headers"
            :items="listaSquads"
            class="elevation-1"
          >
            <template slot="items" slot-scope="props">
              <th>{{ props.item.id }}</th>
              <td>{{ props.item.nome }}</td>
              <td>{{ props.item.nomeTribo || 'Nenhuma' }}</td>
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
              Sem Itens
            </template>
          </v-data-table>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
import SquadsAPI from '../../../domain/services/SquadsAPI'
import TribosAPI from '../../../domain/services/TribosAPI'

export default {
  data: () => ({
    dialog: false,
    listaSquads: [],
    listaTribos: [],
    headers: [
      { text: 'ID', value: 'id' },
      { text: 'Nome', value: 'nome' },
      { text: 'Tribo', value: 'nomeTribo' },
      { text: 'Ativo?', value: 'ativo', sortable: false },
      { text: 'Ações', value: 'nome', sortable: false }
    ],
    hasMentor: false,
    editedIndex: -1,
    squadInsert: {
      nome: '',
      id_Tribo: ''
    },
    squadInput: {
      id: '',
      nome: '',
      id_Tribo: '',
      nomeTribo: '',
      ativo: ''
    },
    defaultItem: {
      id: '',
      nome: '',
      id_Tribo: '',
      nomeTribo: ''
    }
  }),

  computed: {
    formTitle () {
      return this.editedIndex === -1 ? 'Adicionar Squad' : 'Editar Squad'
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
    limpaInsert () {
      this.squadInsert.id = ''
      this.squadInsert.nome = ''
      this.squadInsert.id_Tribo = ''
    },
    listarSquads () {
      this.initialize()
      SquadsAPI.obterSquad().then(respostaSquads => {
        this.listaSquads = respostaSquads.data
      })
    },
    defineInsert (dados) {
      this.squadInsert.id = dados.id
      this.squadInsert.nome = dados.nome
      this.squadInsert.id_Tribo = dados.id_Tribo
    },
    retornaValores (dados) {
      this.squadInput.id = dados.id
      this.squadInput.nome = dados.nome
      this.squadInput.id_Tribo = dados.id_Tribo
      this.squadInput.nomeTribo = dados.nomeTribo
      this.squadInput.ativo = dados.ativo
    },
    initialize () {
      this.listaSquads = []
    },

    editItem (item) {
      // Alterar aqui o this.pessoas
      this.editedIndex = this.listaSquads.indexOf(item)
      console.log(item)
      this.defineInsert(item)
      this.dialog = true
    },

    deleteItem (item) {
      let msg = 'Tem certeza que deseja desativar esta squad?'
      if (item.ativo === false) {
        msg = 'Tem certeza que deseja ativar esta squad?'
      }
      if (confirm(msg)) {
        SquadsAPI.mudarAtivoSquad(item.id).then(() => {
          this.listarSquads()
        })
      }
    },
    close () {
      this.dialog = false
      setTimeout(() => {
        this.squadInput = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      }, 300)
    },
    save () {
      if (this.editedIndex > -1) {
        SquadsAPI.alterarSquad(this.squadInsert.id, this.squadInsert).then(() => {
          this.listarSquads()
          this.close()
        })
      } else {
        SquadsAPI.inserirSquad(this.squadInsert).then(() => {
          this.listarSquads()
          this.close()
        })
      }
    }
  },
  mounted () {
    this.listarSquads()
    TribosAPI.obterTribo().then(respostaTribo => {
      this.listaTribos = respostaTribo.data
    })
  }
}
</script>
