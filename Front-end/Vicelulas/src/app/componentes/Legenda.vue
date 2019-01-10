<template>
  <v-layout justify-center align-content-center>
    <v-flex d-flex md8 xs12>
      <v-flex md4 xs12 pa-3>
        <v-chip color="cyan" text-color="black">
          <v-avatar>
            <v-icon>bubble_chart</v-icon>
          </v-avatar>
            Tribos: {{ listaTribos.length }}
          </v-chip>
        </v-flex>
        <v-spacer></v-spacer>
        <v-flex md4 xs12 pa-3>
          <v-chip color="cyan" text-color="black">
            <v-avatar>
              <v-icon>grain</v-icon>
            </v-avatar>
            Squads: {{ listaSquads.length }}
          </v-chip>
        </v-flex>
        <v-spacer></v-spacer>
        <v-flex md4 xs12 pa-3 pb-5>
          <v-chip color="cyan" text-color="black">
            <v-avatar>
              <v-icon>person</v-icon>
            </v-avatar>
            Pessoas: {{ listaPessoas.length }}
        </v-chip>
      </v-flex>
    </v-flex>
  </v-layout>
</template>

<script>
import PessoasAPI from '../../domain/services/PessoasAPI'
import TribosAPI from '../../domain/services/TribosAPI'
import SquadsAPI from '../../domain/services/SquadsAPI'

export default {
  name: 'Home',
  data () {
    return {
      listaPessoas: [],
      listaTribos: [],
      listaSquads: []
    }
  },
  // Requisições e Retornos da API para Pessoas, Tribos e Squads
  // Cada this. atribui a resposta da requisição há um array que ta dentro da função data acima
  mounted () {
    PessoasAPI.obterPessoa().then(respostaPessoa => {
      this.listaPessoas = respostaPessoa.data
    })
    TribosAPI.obterTribo().then(respostaTribo => {
      this.listaTribos = respostaTribo.data
    })
    SquadsAPI.obterSquad().then(respostaSquad => {
      this.listaSquads = respostaSquad.data
    })
    SquadsAPI.obterSquadSemTribo().then(respostaSquad => {
      this.listaSquads = respostaSquad.data
    })
  }
}
</script>

<style>
/* @import url('https://fonts.googleapis.com/css?family=Kalam:700'); */

.legenda {
  font-family: 'Kalam', coursive;
  width: 20%;
}
.flex {
  display: inline;
  flex-wrap: wrap;
}
</style>
