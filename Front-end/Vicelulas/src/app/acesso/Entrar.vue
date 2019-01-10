<template>
  <v-container fluid>
    <v-layout align-center justify-center>
      <v-flex md5 xs12 pt-5>
        <aviso :ativo="aviso.ativado" :mensagem="aviso.mensagem"/>
        <v-card dark>
          <v-card-text>
            <v-form>
              <v-text-field
              v-model="loginInput.email"
              prepend-icon="person"
              name="username"
              label="Usuário"
              type="text"
              autofocus
              color="red"
              ></v-text-field>
              <v-text-field
              v-model="loginInput.senha"
              prepend-icon="lock"
              name="senha"
              label="Senha"
              type="password"
              color="red"
              ></v-text-field>
            </v-form>
          </v-card-text>
          <!--  -->
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn pa-2 v-show="loginInput.email && loginInput.senha" color="red" @click="fazerLogin" flat>Entrar</v-btn>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import AutenticacaoAPI from '../../domain/services/AutenticacaoAPI'
import Aviso from '../componentes/Aviso'

export default {
  data () {
    return {
      loginInput: {
        email: '',
        senha: ''
      },
      aviso: {
        ativado: false,
        mensagem: ''
      }
    }
  },
  components: {
    'aviso': Aviso
  },
  methods: {
    fazerLogin () {
      AutenticacaoAPI.entrar(this.loginInput).then(resposta => {
        localStorage.setItem('estarLogado', 'TokenGrupoViceri')
        this.$router.push('/tribo')
      }).catch(err => {
        console.log(err)
        this.aviso.ativado = true
        this.aviso.mensagem = 'Dados inseridos são invalidos'
      })
    }
  },
  created () {
    if (localStorage.getItem('estarLogado') === 'TokenGrupoViceri') {
      this.$router.push('/tribo')
    }
  }
}
</script>
