<template>
<v-container grid-list-xs>
  <v-layout row wrap justify-center>
    <v-flex md6 xs12>
      <v-card dark>
        <v-form class="margemSeguranca" ref="form" v-model="valid" lazy-validation>
          <v-text-field
            v-model="nome"
            :rules="nomeRegras"
            :counter="50"
            label="Nome da Tribo"
            required
          ></v-text-field>
          <v-btn
            :disabled="!valid"
            @click="adicionar"
          >
            Adicionar
          </v-btn>
          <v-btn @click="clear">Limpar</v-btn>
        </v-form>
      </v-card>
    </v-flex>
  </v-layout>
</v-container>
</template>

<script>
  import { http } from '../../../domains/api/config'

  export default {
    data: () => ({
      valid: true,
      nome: '',
      nomeRegras: [
        v => !!v || 'Nome da Tribo é um campo obrigatório!',
        v => (v && v.length >= 2) || 'Um nome de Tribo tem que ser maior que 2 caracteres'
      ]
    }),

    methods: {
      submit () {
        if (this.$refs.form.validate()) {
          http.post('/Tribos/Inserir', {
            nome: this.nome
          })
        }
      },
      clear () {
        this.$refs.form.reset()
      }
    }
  }
</script>

<style>
.margemSeguranca {
  padding: 10px;
}
</style>
