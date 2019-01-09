<template>
  <v-slide-y-transition mode="out-in">
    <v-container fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex pt-5 xs12>
          <v-chip color="cinza" text-color="white">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
            {{ avisoLegenda }}
          </v-chip>
        </v-flex>
        <v-flex pt-3 md8 xs12>
          <!-- Icones das Tribos -->
          <v-flex
            v-for="tribo in listaTribos"
            :key="tribo.id"
            class="flex"
          >
            <router-link :to="{ name: 'Tribos', params: { id: tribo.id }}">
              <!-- SVG Dinamico, cria as imagens conforme a API fornece dados -->
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <!-- Imagem de Fundo - Célula -->
                <image :xlink:href="img" x="0" y="0" height="100%" width="100%"></image>
                <!-- Titulo -->
                <text
                  x="50%" y="50%" class="fundo"
                  fill="black"
                  dominant-baseline="middle" text-anchor="middle"
                  font-size="100%"
                >
                  {{ tribo.nome }}
                </text>
              </svg>
            </router-link>
          </v-flex>
          <!-- Icones das Squads -->
          <v-flex
            v-for="squad in listaSquadSemTribo"
            :key="squad.id + 150"
            class="flex"
          >
            <router-link :to="{ name: 'Tribos', params: { id: squad.id }}">
              <!-- SVG Dinamico, cria as imagens conforme a API fornece dados -->
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <!-- Imagem de Fundo - Célula -->
                <image :xlink:href="img" x="0" y="0" height="100%" width="100%"></image>
                <!-- Titulo -->
                <text
                  x="50%" y="50%" class="fundo"
                  fill="black"
                  dominant-baseline="middle" text-anchor="middle"
                  font-size="100%"
                >
                  {{ squad.nome }}
                </text>
              </svg>
            </router-link>
          </v-flex>
          <Legenda />
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
import Legenda from '../componentes/Legenda'
import PessoasAPI from '../../domain/services/PessoasAPI'
import TribosAPI from '../../domain/services/TribosAPI'
import SquadsAPI from '../../domain/services/SquadsAPI'

export default {
  name: 'Home',
  components: {
    Legenda
  },
  data () {
    return {
      avisoLegenda: 'Tribos e Squads do Organismo Viceri',
      img: require('../../../static/icones/cell.png'),
      listaPessoas: [],
      listaTribos: [],
      listaSquadSemTribo: []
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
    SquadsAPI.obterSquadSemTribo().then(respostaSquadSemTribo => {
      this.listaSquadSemTribo = respostaSquadSemTribo.data
    })
  }
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css?family=Kalam:700');

a {
  text-decoration: none;
  text-transform: uppercase;
}
.flex {
  display: inline;
  flex-wrap: wrap;

}
.zoom {
  padding: 15px;
  transition: transform .2s;
  width: 150px;
  height: 150px;
  margin: 0 auto;
}
.zoom:hover {
  transform: scale(1.3);
}
.fundo {
  font-family: 'Kalam', cursive;
  border-radius: 10px;
}
</style>
