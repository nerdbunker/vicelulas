<template>
  <div id="pessoa">
    <v-container grid-list-xs>
      <v-layout row wrap>
        <v-flex md10 xs12>
          <v-toolbar flat dark>
            <v-toolbar-title>PESSOAS</v-toolbar-title>
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
                        <v-text-field v-model="pessoaInput.nome" label="Nome Completo"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="pessoaInput.email" label="Email"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="cargo"
                          item-value="id"
                          v-model="pessoaInput.id_papel"
                          label="Cargo"
                          :items="Papel"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="nome"
                          item-value="id"
                          :items="Unidade"
                          v-model="pessoaInput.id_unidade"
                          label="Unidade"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="nome"
                          item-value="id"
                          :items="Squads"
                          v-model="pessoaInput.id_squads"
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
          <v-data-table
            :headers="headers"
            :items="pessoas"
            class="elevation-1"
          >
            <template slot="items" slot-scope="props">
              <td>{{ props.item.nome }}</td>
              <td>{{ props.item.email }}</td>
              <td>{{ props.item.cargo }}</td>
              <td>{{ props.item.unidade }}</td>
              <td>{{ props.item.squadNome }}</td>
              <td>{{ props.item.triboNome }}</td>
              <td>
                <div v-if="props.item.ativo === true">Sim</div>
                <div v-else>Não</div>
              </td>
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
                @click="deleteItem(props.item), location.reload(true)"
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
import Pessoas from '../../../domain/services/Pessoas'
import Papel from '../../../domain/services/Papel'
import Unidade from '../../../domain/services/Unidade'
import Squads from '../../../domain/services/Squads'
// import { http } from '../../../domain/api/config'

export default {
  data: () => ({
    dialog: false,
    headers: [
      {
        text: 'Nome',
        align: 'left',
        sortable: false,
        value: 'nome'
      },
      { text: 'Email', value: 'email' },
      { text: 'Cargo', value: 'cargo' },
      { text: 'Unidade', value: 'unidade' },
      { text: 'Squad', value: 'id_Squads' },
      { text: 'Tribo', value: 'tribo' },
      { text: 'Ativo?', value: 'ativo' },
      { text: 'Ações', value: 'nome' }
    ],
    editedIndex: -1,
    pessoas: [],
    pessoaInput: {
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
    reloadPage () {
      setTimeout(function () {
        window.location.reload(true)
      }, 1000)
    },
    editItem (item) {
      // Alterar aqui o this.pessoas
      this.editedIndex = this.pessoas.indexOf(item)
      this.pessoaInput = Object.assign({}, item)
      this.dialog = true
    },
    deleteItem (item) {
      // const index = this.pessoas.indexOf(item)
      let msg = 'Tem certeza que deseja desativar esta Pessoa?'
      if (item.ativo === false) {
        msg = 'Tem certeza que deseja ativar esta Pessoa?'
      }
      confirm(msg) &&
      // Ativa/Desativa da API
      Pessoas.mudarAtivoPessoa(item.id)
      this.reloadPage()
      // Remove da lista do Front
      // this.pessoas.splice(index, 1)
    },
    close () {
      this.dialog = false
      setTimeout(() => {
        this.pessoaInput = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      }, 300)
    },
    save () {
      if (this.editedIndex > -1) {
        Object.assign(this.pessoas[this.editedIndex], this.pessoaInput)
        this.pessoas.push(this.pessoaInput)
        Pessoas.alterarPessoa(this.pessoaInput.id, this.pessoaInput)
        this.reloadPage()
      } else {
        this.pessoas.push(this.pessoaInput)
        Pessoas.inserirPessoa(this.pessoaInput)
        this.reloadPage()
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
    Papel.obterPapel().then(respostaPapel => {
      console.log(respostaPapel.data)
      this.Papel = respostaPapel.data
      console.log(Papel)
    })
    Unidade.unidades().then(respostaUnidade => {
      this.Unidade = respostaUnidade.data
    })
    Squads.obterSquad().then(respostaSquads => {
      this.Squads = respostaSquads.data
    })
  }
}
</script>
