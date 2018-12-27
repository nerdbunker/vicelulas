<template>
  <v-container grid-list-xs>
    <v-layout row wrap justify-center>
      <v-flex md6 xs12>
        <v-card dark>
          <form class="margemSeguranca">
            <v-text-field
              v-model="nome"
              :error-messages="nomeErro"
              :counter="50"
              label="Name"
              required
              @input="$v.name.$touch()"
              @blur="$v.name.$touch()"
            ></v-text-field>
            <v-text-field
              v-model="senha"
              :counter="5"
              label="Senha"
              required
              @input="$v.senha.$touch()"
              @blur="$v.senha.$touch()"
            ></v-text-field>
            <v-text-field
              v-model="email"
              :error-messages="emailErro"
              label="E-mail"
              required
              @input="$v.email.$touch()"
              @blur="$v.email.$touch()"
            ></v-text-field>
            <v-select
              v-model="select"
              :items="papel"
              :error-messages="selectErrors"
              label="Papel"
              required
              @change="$v.select.$touch()"
              @blur="$v.select.$touch()"
            ></v-select>
            <v-select
              v-model="select"
              :items="unidade"
              :error-messages="selectErro"
              label="Unidades"
              required
              @change="$v.select.$touch()"
              @blur="$v.select.$touch()"
            ></v-select>
            <v-btn @click="submit">submit</v-btn>
            <v-btn @click="clear">clear</v-btn>
          </form>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import { validationMixin } from 'vuelidate'
import { required, maxLength, email } from 'vuelidate/lib/validators'

export default {
  mixins: [validationMixin],

  validations: {
    name: { required, maxLength: maxLength(50) },
    email: { required, email },
    senha: { required },
    select: { required }
  },

  data: () => ({
    name: '',
    email: '',
    senha: '',
    select: null,
    unidade: [],
    papel: []
  }),

  computed: {
    selectErro () {
      const errors = []
      if (!this.$v.select.$dirty) return errors
      !this.$v.select.required && errors.push('Campo obrigatório. Preencha para continuar!')
      return errors
    },
    nomeErro () {
      const errors = []
      if (!this.$v.name.$dirty) return errors
      !this.$v.name.maxLength && errors.push('O nome não pode ter mais que 50 caracteres.')
      !this.$v.name.required && errors.push('Name é um campo obrigatório.')
      return errors
    },
    emailErro () {
      const errors = []
      if (!this.$v.email.$dirty) return errors
      !this.$v.email.email && errors.push('Insira um e-mail válido.')
      !this.$v.email.required && errors.push('E-mail é um campo obrigatório.')
      return errors
    }
  },

  methods: {
    submit () {
      this.$v.$touch()
    },
    clear () {
      this.$v.$reset()
      this.name = ''
      this.email = ''
      this.senha = ''
      this.select = null
    }
  }
}
</script>

<style>
.margemSeguranca {
  padding: 10px;
}
</style>
