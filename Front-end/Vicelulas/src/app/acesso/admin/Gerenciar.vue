<template>
  <v-layout row wrap justify-center align-content-center>
    <v-flex>
      <v-tabs dark fixed-tabs>
        <v-tab
          v-for="(aba, i) in abas"
          :key="i"
          :to="aba.to"
        >
          {{ aba.titulo }}
        </v-tab>
      </v-tabs>
    </v-flex>
    <!--  -->
    <v-flex xs12>
      <v-content>
        <router-view></router-view>
      </v-content>
    </v-flex>
  </v-layout>
</template>

<script>
export default {
  name: 'Gerenciar',
  data () {
    return {
      abas: [
        { titulo: 'Tribo', to: '/tribo' },
        { titulo: 'Squad', to: '/squad' },
        { titulo: 'Pessoa', to: '/pessoa' },
        { titulo: 'Histórico', to: '/historico' }
      ]
    }
  }
}
</script>
