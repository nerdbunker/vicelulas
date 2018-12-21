<template>
 <v-container fluid grid-list-md text-xs-center>
  <v-layout row wrap justify-center align-content-center>
    <v-flex xs12 md5>
      <v-card>
        <v-card-title primary-title>
          SQUAD {{ $route.params.id }}
        </v-card-title>
        <v-divider></v-divider>
        <v-list>
          <v-list-tile
            v-for="item in items"
            :key="item.title"
            avatar
            @click="link"
          >
           <v-list-tile-avatar>
              <img :src="item.avatar">
            </v-list-tile-avatar>
            <v-list-tile-content>
              <v-list-tile-title v-text="item.title"></v-list-tile-title>
              <v-list-tile-sub-title v-text="item.cargo"></v-list-tile-sub-title>
            </v-list-tile-content>
          </v-list-tile>
          <v-divider></v-divider>
        </v-list>
        <v-btn to="/tribos/squads" color="teal">
        <v-icon>arrow_back</v-icon>
      </v-btn>
      </v-card>
    </v-flex>
  </v-layout>
 </v-container>
</template>

<script>
export default {
  data () {
    return {
      items: [
        { title: 'Mateus', cargo: 'Analista - P.O', avatar: 'https://cdn.vuetifyjs.com/images/lists/1.jpg' },
        { title: 'Lucas', cargo: 'Q.A', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg' },
        { title: 'Isac', cargo: 'Dev', avatar: 'https://cdn.vuetifyjs.com/images/lists/1.jpg' },
        { title: 'Fernando', cargo: 'Dev', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg' },
        { title: 'Pedro', cargo: 'Dev', avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg' }
      ]
    }
  }
}
</script>
