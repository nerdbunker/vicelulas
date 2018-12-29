<template>
  <v-slide-y-transition mode="out-in">
    <v-container fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex pt-5 xs12>
          <v-chip color="cinza" text-color="white">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
            {{ legenda }}
          </v-chip>
        </v-flex>
        <v-flex pt-3 md8 xs12>
          <v-flex
            v-for="tribo in tribos"
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
        </v-flex>
        <v-flex d-flex md8 xs12>
        <v-flex md4 xs12 pa-3>
          <v-chip color="teal" text-color="black">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
              Tribos: {{ tribos.length }}
            </v-chip>
          </v-flex>
          <v-spacer></v-spacer>
          <v-flex md4 xs12 pa-3>
            <v-chip color="teal" text-color="black">
              <v-avatar>
                <v-icon>grain</v-icon>
              </v-avatar>
              Squads: {{ squads.length }}
            </v-chip>
          </v-flex>
          <v-spacer></v-spacer>
          <v-flex md4 xs12 pa-3 pb-5>
            <v-chip color="teal" text-color="black">
              <v-avatar>
                <v-icon>person</v-icon>
              </v-avatar>
              Pessoas: {{ pessoas.length }}
            </v-chip>
          </v-flex>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
import Pessoas from '../../domain/services/Pessoas'
import Tribos from '../../domain/services/Tribos'
import Squads from '../../domain/services/Squads'

export default {
  name: 'Home',
  data () {
    return {
      legenda: 'Tribos e Squads do Organismo Viceri',
      img: require('../../../static/icones/cell.png'),
      pessoas: [],
      tribos: [],
      squads: []
    }
  },
  // Requisições e Retornos da API para Pessoas, Tribos e Squads
  // Cada this. atribui a resposta da requisição há um array que ta dentro da função data acima
  mounted () {
    Pessoas.obterPessoa().then(respostaPessoa => {
      console.log(respostaPessoa)
      this.pessoas = respostaPessoa.data
    })
    Tribos.obterTribo().then(respostaTribo => {
      console.log(respostaTribo)
      this.tribos = respostaTribo.data
    })
    Squads.obterSquad().then(respostaSquad => {
      console.log(respostaSquad)
      this.squads = respostaSquad.data
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
