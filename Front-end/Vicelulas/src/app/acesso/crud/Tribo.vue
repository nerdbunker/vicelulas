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
                        <v-text-field v-model="triboInsert.nome" label="Nome da Tribo"></v-text-field>
                      </v-flex>
                    </v-layout>
                  </v-container>
                  <template>
                    <v-container fluid px-0>
                      <v-checkbox
                        :label="`Checkbox 1: ${checkbox.toString()}`"
                        v-model="checkbox"
                      ></v-checkbox>
                      <v-radio-group v-model="radioGroup">
                        <v-radio
                          v-for="n in 3"
                          :key="n"
                          :label="`Radio ${n}`"
                          :value="n"
                        ></v-radio>
                      </v-radio-group>
                      <v-switch
                        :label="`Switch 1: ${switch1.toString()}`"
                        v-model="switch1"
                      ></v-switch>
                    </v-container>
                  </template>
                </v-card-text>

                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn color="blue darken-1" flat @click="close">Cancelar</v-btn>
                  <v-btn color="blue darken-1" v-show="triboInsert.nome" flat @click="save">Salvar</v-btn>
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
              <th>{{ props.item.id }}</th>
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
              Sem Itens
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
      { text: 'ID', value: 'id' },
      { text: 'Nome', value: 'nome' },
      { text: 'Ativo?', value: 'ativo', sortable: false },
      { text: 'Ações', value: 'acoes', sortable: false }
    ],
    editedIndex: -1,
    triboInsert: {
      id: '',
      nome: ''
    },
    triboInput: {
      nome: '',
      ativo: ''
    },
    defaultItem: {
      id: '',
      nome: ''
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
    listarTribos () {
      TribosAPI.obterTribo().then(respostaTribo => {
        this.listaTribos = respostaTribo.data
      })
    },
    retornaValores (dados) {
      this.triboInput.id = dados.id
      this.triboInput.nome = dados.nome
      this.triboInput.ativo = dados.ativo
    },
    initialize () {
      this.listaTribos = []
    },

    editItem (item) {
      // Alterar aqui o this.tribos
      this.editedIndex = this.listaTribos.indexOf(item)
      this.triboInsert = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem (item) {
      let msg = 'Tem certeza que deseja desativar esta tribo?'
      if (item.ativo === false) {
        msg = 'Tem certeza que deseja ativar esta tribo?'
      }
      confirm(msg)
      TribosAPI.mudarAtivoTribo(item.id).then(() => {
        this.listarTribos()
      })
    },

    close () {
      this.dialog = false
      setTimeout(() => {
        this.triboInsert = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      }, 300)
    },

    save () {
      if (this.editedIndex > -1) {
        TribosAPI.alterarTribo(this.triboInsert.id, this.triboInsert).then(() => {
          this.listarTribos()
        })
      } else {
        TribosAPI.inserirTribo(this.triboInsert).then(() => {
          this.listarTribos()
        })
      }
      this.close()
    }
  },
  mounted () {
    this.listarTribos()
  }
}
</script>
