<template>
  <div id="app" class="bg">
    <v-layout row wrap>
      <v-app id="inspire">
        <v-navigation-drawer
          dark
          persistent
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
          color="red"
          app
          :clipped-left="clipped"
        >
          <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
          <v-list-tile-title text-xs-center class="title">
            Vicélulas
          </v-list-tile-title>
        </v-toolbar>
        <!-- Conteúdo -->
        <v-content>
          <router-view/>
        </v-content>
        <!-- Botão -->
        <v-btn
          fab fixed
          bottom right
          dark center
          onclick="location.reload(true)"
          v-show="$vuetify.breakpoint.xs"
          >
          <v-icon dark>refresh</v-icon>
        </v-btn>
      </v-app>
    </v-layout>
  </div>
</template>

<script>
export default {
  name: 'App',
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
  methods: {
    reloadPage () {
      window.location.reload()
    }
  },
  watch: {
    $route(to, from) {
      this.$store.state.bounceFix.fixBounce();
    }
  }
}
</script>

<style lang="scss">
.bg {
  background-image: url('../static/backgrounds/mol-bg.png');
  background-attachment: fixed;
  background-size: cover;
}
#inspire {
  background: none;
}
// overflow {
//   auto;
//   -webkit-overflow-scrolling: touch;
// }
</style>
