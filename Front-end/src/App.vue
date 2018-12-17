<template>
  <v-app id="app">
    <v-navigation-drawer
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
        >
          <v-list-tile-action>
            <v-icon light='' v-html="item.icon"></v-icon>
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title v-text="item.title"></v-list-tile-title>
          </v-list-tile-content>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer>
    <v-toolbar
      app
      :clipped-left="clipped"
    >
      <v-btn icon @click.stop="miniVariant = !miniVariant">
        <v-icon v-html="miniVariant ? 'chevron_right' : 'chevron_left'"></v-icon>
      </v-btn>
      <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
      <v-toolbar-title :v-text="items"></v-toolbar-title>
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
      drawer: true,
      fixed: false,
      miniVariant: false,
      items: [
        { icon: 'bubble_chart', title: 'Organismo', to: '/' },
        { icon: 'group_work', title: 'Tribos', to: '/tribos' },
        { icon: 'scatter_plot', title: 'Squads', to: '/squads' },
        { icon: 'loyalty', title: 'Valores', to: '/valores' },
        { icon: 'photo', title: 'Viceri', to: '/viceri' },
        { icon: 'info', title: 'Dúvidas', to: '/duvidas' },
        { icon: 'developer_mode', title: 'Suporte', to: '/suporte' },
        { icon: 'fingerprint', title: 'Entrar', to: '/login' }
        // { icon: 'person_add', title: 'Adicionar Membro', to: '/cadastro' }
      ]
    }
  },
  name: 'App'
}
</script>
