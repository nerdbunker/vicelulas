<template>
  <v-container grid-list-xs>
    <v-layout row wrap>
      <v-flex md6 xs12>
        <v-card class="margemSeguranca" dark>
          <v-form ref="form" v-model="valid" lazy-validation>
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
              v-model="senha"
              :rules="senhaRegras"
              label="Senha"
              required
            ></v-text-field>
            <v-select
              v-model="select"
              :items="papeis"
              value="papeis.id_papel"
              :rules="[v => !!v || 'Papel precisa ser preenchido.']"
              label="Papel"
              required
            ></v-select>
            <v-select
              v-model="select"
              :items="squads"
              value="squads.id_squads"
              :rules="[v => !!v || 'Squad precisa ser preenchida.']"
              label="Squad"
              required
            ></v-select>
            <v-select
              v-model="select"
              :items="unidades"
              value="unidades.id_unidades"
              :rules="[v => !!v || 'Unidade precisa ser preenchida.']"
              label="Unidade"
              required
            ></v-select>

            <v-btn
              :disabled="!valid"
              @click="submit"
            >
              Enviar
            </v-btn>
            <v-btn @click="clear">Limpar</v-btn>
          </v-form>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import { http } from '../../domains/api/config'
import Squad from '../../domains/services/Squads'

export default {
  data: () => ({
    valid: true,
    nome: '',
    nameRegras: [
      v => !!v || 'Nome é um campo obrigatório.',
      v => (v && v.length <= 50) || 'O nome deve ter menos de 50 caracteres.'
    ],
    email: '',
    emailRegras: [
      v => !!v || 'E-mail é um campo obrigatório.',
      v => /.+@.+/.test(v) || 'Insira um e-mail válido.'
    ],
    select: null,
    papeis: [],
    squads: [],
    unidades: [],
    checkbox: false
  }),

  methods: {
    submit () {
      if (this.$refs.form.validate()) {
        // Native form submission is not yet supported
        http.post('Cadastrar', {
          id: this.id,
          name: this.name,
          email: this.email,
          select: this.select,
          checkbox: this.checkbox
        })
      }
    },
    clear () {
      this.$refs.form.reset()
    }
  },
  mounted () {
    Squad.obterSquad().then(respostaSquad => {
      console.log(respostaSquad)
      this.squads = respostaSquad.data
    })
    Papel.obterPapel().then(respostaPapel => {
      console.log(respostaPapel)
      this.squads = respostaPapel.data
    })
  }
}
</script>

<style scoped>
.margemSeguranca {
  padding: 20px;
}
</style>
