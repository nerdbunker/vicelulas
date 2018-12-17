<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex row wrap elevation-5 xs10>
        <v-flex xs12>
          <v-card elevation-10>
            <v-tabs
              centered
              color="teal"
              dark
              icons-and-text
            >
              <v-tabs-slider color="black"></v-tabs-slider>

              <v-tab href="#tab-1">
                Tribos
                <v-icon>group_work</v-icon>
              </v-tab>

              <v-tab href="#tab-2">
                Squads
                <v-icon>scatter_plot</v-icon>
              </v-tab>

              <v-tab href="#tab-3">
                Pessoas
                <v-icon>person</v-icon>
              </v-tab>

              <v-tab-item
                v-for="i in 3"
                :id="'tab-' + i"
                :key="i"
              >
              </v-tab-item>
            </v-tabs>
          </v-card>
        </v-flex>
        <v-flex d-flex xs12>
          <v-flex md4 xs12>
            <v-text-field
              color="green"
              v-model="search"
              append-icon="search"
              label="Pesquisar"
              single-line
              hide-details
            ></v-text-field>
            <v-list two-line>
              <template light v-for="(item, index) in items">
                <v-subheader
                  v-if="item.header"
                  :key="item.header"
                >
                  {{ item.header }}
                </v-subheader>

                <v-divider
                  v-else-if="item.divider"
                  :inset="item.inset"
                  :key="index"
                ></v-divider>

                <v-list-tile
                  v-else
                  :key="item.title"
                  avatar
                  @click="link"
                >
                  <v-list-tile-avatar>
                    <img :src="item.avatar">
                  </v-list-tile-avatar>

                  <v-list-tile-content>
                    <v-list-tile-title v-html="item.title"></v-list-tile-title>
                    <v-list-tile-sub-title v-html="item.subtitle"></v-list-tile-sub-title>
                  </v-list-tile-content>
                </v-list-tile>
              </template>
            </v-list>
          </v-flex>
          <v-spacer></v-spacer>
          <v-flex md8 xs12>
            <!-- Campos para edição -->
            <v-text-field
              class="search"
              prepend-icon="person"
              name="papel"
              label="Nome"
              id="id"
            ></v-text-field>
            <v-combobox
              class="search"
              prepend-icon="work"
              v-model="select"
              :items="cargos"
              label="Papel"
              required
            ></v-combobox>
            <v-combobox
              class="search"
              prepend-icon="home"
              v-model="select"
              :items="unidades"
              label="Unidade"
              required
            ></v-combobox>
            <v-text-field
              prepend-icon="create"
              class="search"
              label="Feedback e Avaliação"
              v-model="value"
            ></v-text-field>
            <v-btn small color="teal">
              Alterar
            </v-btn>
          </v-flex>
        </v-flex>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
  export default {
    data () {
      return {
        items: [
          { header: 'Pessoas' },
          {
            avatar: 'https://cdn.vuetifyjs.com/images/lists/1.jpg',
            title: 'Marcos Pontes',
            subtitle: 'Arquiteto Front-end'
          },
          { divider: true, inset: false },
          {
            avatar: 'https://cdn.vuetifyjs.com/images/lists/2.jpg',
            title: 'Fernando Machado',
            subtitle: 'Arquiteto de Testes'
          },
          { divider: true, inset: false },
          {
            avatar: 'https://cdn.vuetifyjs.com/images/lists/3.jpg',
            title: 'Juliana Gomes',
            subtitle: 'Analista de Negócios'
          }
        ],
        cargos: [
          'Gerente',
          'Coordenador',
          'Analista de Negócios',
          'Analista de Sistemas',
          'Arquiteto Back-end',
          'Arquiteto Front-end',
          'Cientista de Dados',
          'Desenvolvedor Sênior',
          'Desenvolvedor Pleno',
          'Desenvolvedor Junior',
          'Desenvolvedor Treinee',
          'Desenvolvedor Estagiário'
        ],
        unidades: [
          'Viceri Specialist - General Osório',
          'Viceri Specialist - Edificio Vila Jobim',
          'Viceri Ventures - Nove de Julho',
          'Viceri Solutions - São Paulo'
        ]
      }
    }
  }
</script>

<style>
.search {
  margin-right: 5px;
  margin-left: 5px;
  margin-bottom: 10px;
}
.top {
  padding-top: 10px;
}
</style>
