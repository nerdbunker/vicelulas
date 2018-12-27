<template>
<v-container grid-list-xs>
  <v-layout row wrap justify-center>
    <v-flex pb-5 md6 xs12>
      <v-card dark>
        <v-form class="margemSeguranca" ref="form" v-model="valid" lazy-validation>
          <v-text-field
            v-model="nome"
            :rules="nomeRegras"
            :counter="50"
            label="Nome"
            required
          ></v-text-field>
          <v-text-field
            v-model="email"
            :rules="emailRegras"
            label="E-mail"
            required
          ></v-text-field>
          <v-text-field
            v-model="username"
            :rules="usernameRegras"
            label="Username"
            required
          ></v-text-field>
          <v-select
            v-model="select"
            :items="papeis"
            :rules="[v => !!v || 'Papel é um campo obrigatório!']"
            label="Papel"
            required
          ></v-select>
          <v-select
            v-model="select"
            :items="squads"
            :rules="[v => !!v || 'Squad é um campo obrigatório!']"
            label="Squad"
            required
          ></v-select>
          <v-select
            v-model="select"
            :items="unidades"
            :rules="[v => !!v || 'Unidade é um campo obrigatório!']"
            label="Unidade"
            required
          ></v-select>
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
import Squads from '../../../domains/services/Squads'

export default {
  data: () => ({
    valid: true,
    name: '',
    nomeRegras: [
      v => !!v || 'Nome é um campo obrigatório!',
      v => (v && v.length <= 50) || 'O nome deve ser menos que 50 caracteres'
    ],
    email: '',
    emailRegras: [
      v => !!v || 'E-mail é um campo obrigatório!',
      v => /.+@.+/.test(v) || 'Insira um e-mail válido'
    ],
    select: null,
    papeis: [],
    squads: [],
    unidades: []
  }),

  methods: {
    submit () {
      if (this.$refs.form.validate()) {
        http.post('/Pessoa/Adicionar', {
          name: this.name,
          email: this.email,
          username: this.username,
          id_papel: this.papeis,
          id_unidade: this.unidades,
          select: this.select
        })
      }
    },
    clear () {
      this.$refs.form.reset()
    }
  },
  mounted () {
    Squads.obterSquad().then(respostaSquad => {
      console.log(respostaSquad)
      this.squads = respostaSquad
    })
  }
}
</script>

<style>
.margemSeguranca {
  padding: 10px;
}
</style>
