<template>
  <div id="app" class="bg">
    <v-app id="inspire">
      <v-navigation-drawer
        dark
        persistent
        v-model="drawer"
        fixed app width="200"
      >
        <v-list>
          <v-flex class="bg-white">
            <router-link to="/" aria-label="logo">
              <img src="../static/icones/logo.png" class="logo" alt="Grupo Viceri - Logo">
            </router-link>
          </v-flex>
          <v-divider></v-divider>
          <v-list-tile
            value="true"
            v-for="(item, i) in items"
            :key="i"
            :to="item.to"
            active-class="active"
            exact-active-class="primary"
          >
            <v-list-tile-action>
              <v-icon v-html="item.icon"></v-icon>
            </v-list-tile-action>
            <v-list-tile-content>
              <v-list-tile-title v-text="item.title"></v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
        </v-list>
      </v-navigation-drawer>
      <v-toolbar
        class="white--text"
        flat
        color="viceri"
        app
      >
        <v-toolbar-side-icon class="white--text" aria-label="menu" @click.stop="drawer = !drawer"></v-toolbar-side-icon>
        <v-list-tile-title text-xs-center class="titulo">
          {{ titulo }}
        </v-list-tile-title>
        <v-spacer></v-spacer>
      </v-toolbar>
      <!-- Conteúdo -->
      <v-content>
        <router-view/>
      </v-content>
      <!-- Menu Inferior [apenas no mobile] -->
      <Menu />
      <v-flex v-show="$vuetify.breakpoint.lg">
        <v-btn
          onclick="history.back()"
          fab dark fixed right bottom
         >
          <v-icon>mdi-arrow-left</v-icon>
        </v-btn>
      </v-flex>
    </v-app>
  </div>
</template>

<script>
import Menu from './app/componentes/Menu'

export default {
  name: 'App',
  components: {
    Menu
  },
  data () {
    return {
      drawer: false,
      fixed: false,
      titulo: 'VICELULAS',
      items: [
        { icon: 'home', title: 'Organismo', to: '/' },
        // { icon: 'loyalty', title: 'Valores', to: '/valores' },
        { icon: 'photo', title: 'Fotos da Viceri', to: '/viceri' },
        { icon: 'folder', title: 'Documentos', to: '/documentos' },
        { icon: 'info', title: 'Dúvidas', to: '/duvidas' },
        { icon: 'developer_mode', title: 'Suporte', to: '/suporte' },
        { icon: 'fingerprint', title: 'Entrar', to: '/entrar' }
      ]
    }
  }
}
</script>

<style scoped>
#inspire {
  font-family: 'Play', sans-serif;
  background: none;
}
.titulo {
  font-size: 25px;
}
.logo {
  padding-left: 10px;
  width: 190px;
}
</style>
