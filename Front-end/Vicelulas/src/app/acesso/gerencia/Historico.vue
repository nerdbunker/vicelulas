<template>
  <v-container fluid grid-list-md text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex md7 xs12 mb-6 pa-1>
        <v-card>
          <v-toolbar flat>
            <v-text-field
              color="red"
              v-model="search"
              append-icon="search"
              label="Pesquisar"
              single-line
              hide-details
            ></v-text-field>
          </v-toolbar>
          <v-flex
            v-for="(historico, i) in historicos"
            :key="i"
          >
            <v-card flat>
              <v-list>
                {{ historico.nome + ' alterou ' + historico.pessoa + ' do squad ' + historico.squadAnterior + ' para ' + historico.squadAtual + 'Data: 00:00 — 00/00' }}
              </v-list>
              <v-divider></v-divider>
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
export default {
  name: 'Squads',
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
