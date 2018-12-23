<template>
  <v-card
    v-show="$vuetify.breakpoint.xs"
    height="200px"
  >
    <v-bottom-nav
      :active.sync="bottomNav"
      :value="true"
      fixed
    >
      <v-btn
        onclick="history.back()"
      >
        <span>Voltar</span>
        <v-icon>arrow_back</v-icon>
      </v-btn>

      <v-btn
        color="teal"
        flat
        value="Home"
        to="/"
      >
        <span>Home</span>
        <v-icon>home</v-icon>
      </v-btn>

      <v-btn
        onclick="location.reload(true)"
      >
        <span>Atualizar</span>
        <v-icon>refresh</v-icon>
      </v-btn>
      <v-btn
        onclick="history.forward()"
      >
        <span>Avançar</span>
        <v-icon>arrow_forward</v-icon>
      </v-btn>
    </v-bottom-nav>
  </v-card>
</template>

<script>
export default {
  name: 'Menu',
  data () {
    return {
      bottomNav: 'recent'
    }
  },
  methods: {
    reloadPage () {
      window.location.reload()
    }
  }
}
</script>
