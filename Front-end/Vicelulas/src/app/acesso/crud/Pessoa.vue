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
                        <v-text-field v-model="pessoaInsert.nome" label="Nome Completo"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-text-field v-model="pessoaInsert.email" label="Email"></v-text-field>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="cargo"
                          item-value="id"
                          v-model="pessoaInsert.id_Papel"
                          label="Cargo"
                          :items="listaPapeis"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="nome"
                          item-value="id"
                          :items="listaUnidades"
                          v-model="pessoaInsert.id_Unidade"
                          label="Unidade"
                        ></v-select>
                      </v-flex>
                      <v-flex xs12 sm12 md12>
                        <v-select
                          item-text="nome"
                          item-value="id"
                          :items="listaSquads"
                          v-model="pessoaInsert.id_Squads"
                          label="Squad"
                        ></v-select>
                      </v-flex>
                    </v-layout>
                  </v-container>
                    <v-container fluid px-0>
                      <v-switch
                        :label="`Mentor`"
                        v-model="ehMentor"
                      ></v-switch>
                    </v-container>
                </v-card-text>

                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn color="blue darken-1" flat @click="close">Cancelar</v-btn>
                  <v-btn color="blue darken-1" v-show="pessoaInsert.nome && pessoaInsert.email && pessoaInsert.id_Papel && pessoaInsert.id_Unidade && pessoaInsert.id_Squads"  flat @click="save">Salvar</v-btn>
                </v-card-actions>
              </v-card>
            </v-dialog>
          </v-toolbar>
          <v-data-table
            :headers="headers"
            :items="listaPessoas"
            class="elevation-1"
          >
            <template slot="items" slot-scope="props">
              <th>{{ props.item.id }}</th>
              <td>{{ props.item.nome }}</td>
              <td>{{ props.item.email }}</td>
              <td>{{ props.item.cargo }}</td>
              <td>{{ props.item.unidade }}</td>
              <td>{{ props.item.squadNome }}</td>
              <td>{{ props.item.triboNome || 'Nenhuma' }}</td>
              <td>{{ props.item.ativo ? 'Sim':'Não'}}</td>
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
import PessoasAPI from '../../../domain/services/PessoasAPI'
import PapeisAPI from '../../../domain/services/PapeisAPI'
import UnidadesAPI from '../../../domain/services/UnidadesAPI'
import SquadsAPI from '../../../domain/services/SquadsAPI'
// import { http } from '../../../domain/api/config'

export default {
  data: () => ({
    ehMentor: false,
    dialog: false,
    headers: [
      { text: 'ID', value: 'id' },
      { text: 'Nome', value: 'nome' },
      { text: 'Email', value: 'email' },
      { text: 'Cargo', value: 'cargo' },
      { text: 'Unidade', value: 'id_Unidade' },
      { text: 'Squad', value: 'id_Squads' },
      { text: 'Tribo', value: 'tribo' },
      { text: 'Ativo?', value: 'ativo', sortable: false },
      { text: 'Ações', value: 'nome', sortable: false }
    ],
    editedIndex: -1,
    listaPessoas: [],
    listaPapeis: [],
    listaUnidades: [],
    listaSquads: [],
    pessoaInsert: {
      id: '',
      nome: '',
      email: '',
      id_Papel: '',
      id_Unidade: '',
      id_Squads: '',
      permissao: 1
    },
    pessoaInput: {
      id: '',
      nome: '',
      email: '',
      cargo: '',
      unidade: '',
      squadNome: '',
      triboNome: ''
    },
    defaultItem: {
      id: '',
      nome: '',
      email: '',
      cargo: '',
      unidade: '',
      squadNome: '',
      triboNome: ''
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
    retornaPermissao (condicao) {
      if (condicao) this.pessoaInsert.permissao = 2
      else this.pessoaInsert.permissao = 1
    },
    retornaValores (dados) {
      this.pessoaInput.id = dados.id
      this.pessoaInput.nome = dados.nome
      this.pessoaInput.email = dados.email
      this.pessoaInput.cargo = dados.cargo
      this.pessoaInput.unidade = dados.unidade
      this.pessoaInput.squadNome = dados.squadNome
      this.pessoaInput.triboNome = dados.triboNome
    },
    limparInsert () {
      this.pessoaInsert.id = ''
      this.pessoaInsert.nome = ''
      this.pessoaInsert.email = ''
      this.pessoaInsert.id_Papel = ''
      this.pessoaInsert.id_Unidade = ''
      this.pessoaInsert.id_Squads = ''
    },
    listarPessoas () {
      this.initialize()
      PessoasAPI.obterPessoa().then(respostaPessoa => {
        this.listaPessoas = respostaPessoa.data
      })
    },
    initialize () {
      this.listaPessoas = []
    },
    reloadPage () {
      setTimeout(function () {
        window.location.reload(true)
      }, 1000)
    },
    editItem (item) {
      // Alterar aqui o this.pessoas
      this.editedIndex = this.listaPessoas.indexOf(item)
      this.triboInsert = Object.assign({}, item)
      this.pessoaInsert = item
      this.dialog = true
    },
    deleteItem (item) {
      // const index = this.pessoas.indexOf(item)
      let msg = 'Tem certeza que deseja desativar esta Pessoa?'
      if (item.ativo === false) {
        msg = 'Tem certeza que deseja ativar esta Pessoa?'
      }
      if (confirm(msg)) {
        PessoasAPI.mudarAtivoPessoa(item.id).then(() => {
          this.listarPessoas()
        })
      }
    },
    close () {
      this.limparInsert()
      this.listarPessoas()
      this.dialog = false
      setTimeout(() => {
        this.pessoaInput = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      }, 300)
    },
    save () {
      this.retornaPermissao(this.ehMentor)
      if (this.editedIndex > -1) {
        PessoasAPI.alterarPessoa(this.pessoaInsert.id, this.pessoaInsert).then(resposta => {
          this.listarPessoas()
          this.close()
        })
      } else {
        PessoasAPI.inserirPessoa(this.pessoaInsert).then(resposta => {
          this.listarPessoas()
          this.close()
        }).catch(err => console.log(err))
      }
    }
  },
  mounted () {
    this.listarPessoas()
    PapeisAPI.obterPapel().then(respostaPapel => {
      this.listaPapeis = respostaPapel.data
    })
    UnidadesAPI.unidades().then(respostaUnidade => {
      this.listaUnidades = respostaUnidade.data
    })
    SquadsAPI.obterSquad().then(respostaSquads => {
      this.listaSquads = respostaSquads.data
    })
  }
}
</script>
