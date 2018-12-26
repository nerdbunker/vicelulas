<template>
  <v-card
    v-show="$vuetify.breakpoint.xs"
    dark pt-5
  >
    <v-bottom-nav
      value="Botões"
      fixed
    >
      <v-btn
        onclick="history.back()"
        value="Voltar"
      >
        <span>Voltar</span>
        <v-icon>arrow_back</v-icon>
      </v-btn>
      <!-- Botao Home -->
      <v-btn
        to="/"
        value="Home"
      >
        <span>Organismo</span>
        <v-icon>home</v-icon>
      </v-btn>
      <!-- Botao Atualizar -->
      <v-btn
        onclick="location.reload(true)"
        value="Atualizar"
      >
        <span>Atualizar</span>
        <v-icon>refresh</v-icon>
      </v-btn>
      <!-- Botao do Menu - É injetado a partir de outro componente -> /componentes/Links.vue -->
      <Links />
    </v-bottom-nav>
  </v-card>
</template>

<script>
import Links from './Links'

export default {
  name: 'Menu',
  components: {
    Links
  },
  methods: {
    reloadPage () {
      window.location.reload()
    }
  }
}
</script>
