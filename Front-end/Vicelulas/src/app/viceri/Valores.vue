<template>
  <v-container fluid grid-list-xs text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md8 xs12>
        <v-layout row wrap>
          <v-flex
            v-for="card in cards"
            v-bind="{ [`xs${card.flex}`]: true }"
            :key="card.title"
            pa-1
          >
            <v-card dark>
              <v-img
                :src="card.src"
                height="200px"
              >
                <v-container
                  fill-height
                  fluid
                  pa-2
                >
                  <v-layout fill-height>
                    <v-flex xs12 align-end flexbox>
                      <span class="headline white--text" v-text="card.title"></span>
                    </v-flex>
                  </v-layout>
                </v-container>
              </v-img>

              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn icon>
                  <v-icon>favorite</v-icon>
                </v-btn>
                <v-btn icon>
                  <v-icon>bookmark</v-icon>
                </v-btn>
                <v-btn icon>
                  <v-icon>share</v-icon>
                </v-btn>
              </v-card-actions>
            </v-card>
          </v-flex>
        </v-layout>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Valores',
  data: () => ({
    cards: [
      { title: 'Em breve', src: require('../../../static/imagens/viceri.svg'), flex: 12 },
      { title: '...', src: require('../../../static/imagens/viceri.svg'), flex: 6 },
      { title: '....', src: require('../../../static/imagens/viceri.svg'), flex: 6 }
    ]
  })
}
</script>
