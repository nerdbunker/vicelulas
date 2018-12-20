<template>
  <v-app id="app">
    <v-navigation-drawer
      black
      persistent
      :mini-variant="miniVariant"
      :clipped="clipped"
      v-model="drawer"
      enable-resize-watcher
      fixed
      app
    >
      <v-list>
        <v-list-tile
          value="true"
          v-for="(item, i) in items"
          :key="i"
          :to="item.to"
          active-class="active"
          exact-active-class="indigo"
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
      flat
      color="indigo"
      app
      :clipped-left="clipped"
    >
      <v-btn icon @click.stop="miniVariant = !miniVariant">
        <v-icon v-html="miniVariant ? 'chevron_right' : 'chevron_left'"></v-icon>
      </v-btn>
      <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
      <v-list-tile-title class="title">
        Vicélulas
      </v-list-tile-title>
    </v-toolbar>
    <!-- Conteúdo -->
    <v-content>
      <router-view/>
    </v-content>
  </v-app>
</template>

<script>
export default {
  data () {
    return {
      clipped: false,
      drawer: false,
      fixed: false,
      miniVariant: false,
      items: [
        { icon: 'bubble_chart', title: 'Organismo', to: '/' },
        { icon: 'loyalty', title: 'Valores', to: '/valores' },
        { icon: 'photo', title: 'Viceri', to: '/viceri' },
        { icon: 'info', title: 'Dúvidas', to: '/duvidas' },
        { icon: 'developer_mode', title: 'Suporte', to: '/suporte' },
        { icon: 'fingerprint', title: 'Entrar', to: '/login' }
      ]
    }
  },
  name: 'App'
}
</script>
