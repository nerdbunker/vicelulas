<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md6 xs12 mb-6 pa-1>
        <v-card>
          <v-toolbar flat>
            <v-flex 12>
              <Pesquisar />
            </v-flex>
          </v-toolbar>
          <v-flex
            v-for="(historico, i) in historicos"
            :key="i"
          >
            <v-card flat>
              <v-chip color="indigo" text-color="white">
                <v-avatar>
                  <v-icon>history</v-icon>
                </v-avatar>
                {{ historico.nome + ' alterou ' + historico.pessoa + ' do squad ' + historico.squadAnterior + ' para ' + historico.squadAtual + 'Data: 00:00 — 00/00' }}
              </v-chip>
            </v-card>
          </v-flex>
          <v-btn
            to="/gerenciar"
            color="teal"
          >
            <v-icon>arrow_back</v-icon>
          </v-btn>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Pesquisar from '../../componentes/Pesquisar'

export default {
  name: 'Squads',
  components: {
    Pesquisar
  },
  data () {
    return {
      historicos: [
        { nome: 'Anderson', pessoa: 'Pedro', squadAnterior: 'NerdBunker', squadAtual: 'LAMBDA' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Fantatho', pessoa: 'Isac', squadAnterior: 'NerdBunker', squadAtual: 'BUNKERS' },
        { nome: 'Rafaela', pessoa: 'Lucas', squadAnterior: 'NerdBunker', squadAtual: 'NERDS' }
      ]
    }
  }
}
</script>

<style scoped>
.flex {
  display: inline;
  flex-wrap: wrap;
}
.espaco {
  padding: 10px;
}
.search {
  padding-right: 5px;
  padding-left: 5px;
  padding-bottom: 10px;
}
p {
  font-size: 18px;
  padding-top: 15px;
}
.imagem {
  width: 50%;
}
</style>
