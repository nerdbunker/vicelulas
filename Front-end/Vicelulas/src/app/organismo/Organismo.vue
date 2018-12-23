<template>
  <v-slide-y-transition mode="out-in">
    <v-container fluid grid-list-md text-xs-center>
      <v-layout row wrap justify-center align-content-center>
        <v-flex xs12>
          <v-chip color="green" text-color="white">
            <v-avatar>
              <v-icon>bubble_chart</v-icon>
            </v-avatar>
            Você está em: Organismo Viceri.
          </v-chip>
        </v-flex>
        <v-flex md8 xs12>
          <v-flex
            v-for="(tribo, i) in tribos"
            :key="i"
            class="flex"
          >
            <router-link :to="tribo.to">
              <!-- SVG Dinamico, cria as imagens conforme a API fornece dados -->
              <svg class="zoom" height="100px" width="100px" xmlns="http://www.w3.org/2000/svg">
                <!-- Imagem de Fundo - Célula -->
                <image xlink:href="../../../static/icones/cell.png"
                       x="0" y="0" height="100%" width="100%"></image>
                <!-- Fundo do Texto -->
                <filter x="0" y="0" width="1" height="1" id="solid">
                  <feFlood flood-color="red"/>
                  <feComposite in="SourceGraphic"/>
                </filter>
                <!-- Titulo -->
                <text
                  x="50%" y="50%" class="fundo"
                  fill="white" filter="url(#solid)"
                  dominant-baseline="middle" text-anchor="middle"
                  font-size="100%">
                  {{ tribo.name }}
                </text>
              </svg>
            </router-link>
          </v-flex>
        </v-flex>
        <v-flex d-flex md8 xs12>
          <v-flex md4 xs12 pa-3>
            <v-chip color="red" text-color="white">
              <v-avatar>
                <v-icon>bubble_chart</v-icon>
              </v-avatar>
              Tribos: {{ metricas.tribos }}
            </v-chip>
          </v-flex>
          <v-spacer></v-spacer>
          <v-flex md4 xs12 pa-3>
            <v-chip color="green" text-color="white">
              <v-avatar>
                <v-icon>grain</v-icon>
              </v-avatar>
              Squads: {{ metricas.squads }}
            </v-chip>
          </v-flex>
          <v-spacer></v-spacer>
          <v-flex md4 xs12 pa-3>
            <v-chip color="indigo" text-color="white">
              <v-avatar>
                <v-icon>person</v-icon>
              </v-avatar>
              Pessoas: {{ metricas.pessoas }}
            </v-chip>
          </v-flex>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
export default {
  name: 'Home',
  data () {
    return {
      metricas: {
        tribos: 7,
        squads: 15,
        pessoas: 97
      },
      tribos: [
        { name: 'Consultoria', to: '/tribos/consultoria' },
        { name: 'Finamax', to: '/tribos/finamax' },
        { name: 'Global Dev', to: '/tribos/globaldev' },
        { name: 'Viceri', to: '/tribos/globaldev' },
        { name: 'I. Unibanco', to: '/tribos/unibanco' },
        { name: 'MAPFRE', to: '/tribos/mapfre' },
        { name: 'Passarela', to: '/tribos/passarela' },
        { name: 'Produtos', to: '/tribos/produtos' },
        { name: 'Sequoia', to: '/tribos/sequoia' }
      ]
    }
  }
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css?family=Kalam');

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
