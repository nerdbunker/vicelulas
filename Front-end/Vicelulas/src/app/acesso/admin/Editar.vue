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
      <v-flex>
        <v-btn to="/gerenciar" color="blue">
          <v-icon>arrow_back</v-icon>
          Voltar
        </v-btn>
      </v-flex>
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
  name: 'Adicionar',
  data () {
    return {
      abas: [
        { titulo: 'Editar Tribo', to: '/inserirtribo' },
        { titulo: 'Editar Squad', to: '/inserirsquad' },
        { titulo: 'Editar Pessoa', to: '/inserirpessoa' }
      ]
    }
  }
}
</script>
