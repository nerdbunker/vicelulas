<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center>
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
              :append-icon="show ? 'visibility_off' : 'visibility'"
              :rules="[rules.required, rules.min]"
              :type="show ? 'text' : 'password'"
              name="input-10-2"
              label="Senha"
              hint="Insira sua senha de no minimo 5 caracteres."
              value=""
              class="input-group--focused"
              @click:append="show = !show"
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
              Cadastrar
            </v-btn>
            <v-btn @click="clear">Limpar</v-btn>
          </v-form>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import { http } from '../../domain/api/config'
import SquadsAPI from '../../domain/services/SquadsAPI'

export default {
  data: () => ({
    valid: true,
    show: false,
    nome: '',
    password: 'Password',
    rules: {
      required: value => !!value || 'Campo obrigatório.',
      min: v => v.length >= 5 || 'Mínimo: 5 caracteres'
      // emailMatch: () => ('The email and password you entered don\'t match')
    },
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
    SquadsAPI.obterSquad().then(respostaSquad => {
      this.squads = respostaSquad.data
    })
  }
}
</script>

<style scoped>
.margemSeguranca {
  padding: 20px;
}
</style>
