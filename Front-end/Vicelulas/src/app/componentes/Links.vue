<template>
  <v-menu
      bottom
      origin="center center"
    >
      <v-btn
        value="Menu"
        slot="activator"
        transition="scale-transition"
      >
        <span>Menu</span>
        <v-icon>menu</v-icon>
      </v-btn>
      <v-list>
        <v-list-tile
          v-for="(link, i) in links"
          :key="i"
          :to="link.to"
        >
          <v-list-tile-title>{{ link.title }}</v-list-tile-title>
        </v-list-tile>
      </v-list>
    </v-menu>
</template>

<script>
export default {
  name: 'Links',
  data: () => ({
    links: [
      { title: 'Fotos da Viceri', to: '/viceri' },
      { title: 'Dúvidas', to: '/duvidas' },
      { title: 'Documentos', to: '/documentos' },
      { title: 'Suporte', to: '/suporte' },
      { title: 'Entrar', to: '/entrar' }
    ],
    logado: localStorage.getItem('estarLogado')
  })
}
</script>
