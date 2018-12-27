<template>
  <v-layout row justify-center>
    <v-dialog v-model="dialog" persistent max-width="600px">
      <v-btn slot="activator" color="primary" dark>Open Dialog</v-btn>
      <v-card>
        <v-card-title>
          <span class="headline">Editar: Pessoa</span>
        </v-card-title>
        <v-card-text>
          <v-container grid-list-md>
            <v-layout wrap>
              <v-flex xs12 sm6 md4>
                <v-text-field label="Primeiro Completo *" required hint="Ex: Marcelo Fernandes" v-model="pessoa.nome"></v-text-field>
              </v-flex>
              <v-flex xs12 sm6 md4>
                <v-select
                  v-model="pessoa.squad"
                  :items="squads.nome"
                  label="Squad *"
                  hint="Selecione a Squad que a Pessoa pertence!"
                  persistent-hint required autocomplete
                ></v-select>
              </v-flex>
              <v-flex xs12>
                <v-text-field label="E-mail Corporativo *" required v-model="pessoa.email"></v-text-field>
              </v-flex>
              <v-flex xs12>
                <v-text-field label="Unidade *"  required v-model="pessoa.unidade"></v-text-field>
              </v-flex>
            </v-layout>
          </v-container>
          <small>* campos requeridos</small>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" flat @click="dialog = false">Fechar</v-btn>
          <v-btn
            :disabled="dialog"
            :loading="dialog"
            class="white--text"
            flat
            @click="dialog = true"
          >
            Salvar
          </v-btn>
          <v-dialog
            v-model="dialog"
            hide-overlay
            persistent
            width="200"
          >
            <v-card
              color="primary"
              dark
            >
              <v-card-text>
                Espere um instante
                <v-progress-linear
                  indeterminate
                  color="white"
                  class="mb-0"
                ></v-progress-linear>
              </v-card-text>
            </v-card>
          </v-dialog>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-layout>
</template>

<script>
export default {
  name: 'EditarPessoa',
  data () {
    return {
      dialog: false,
      pessoa: {
        id: '',
        nome: '',
        squad: '',
        email: '',
        unidade: ''
      }
    }
  },
  watch: {
    dialog (val) {
      if (!val) return
      setTimeout(() => (this.dialog = false), 4000)
    }
  }
}
</script>
