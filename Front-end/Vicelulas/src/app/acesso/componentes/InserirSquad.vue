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
            label="Nome da Squad"
            required
          ></v-text-field>
          <v-select
            v-model="select"
            :items="tribos"
            :rules="[v => !!v || 'Tribo é um campo obrigatório!']"
            label="Tribo à qual Pertence"
            required
          ></v-select>
          <v-btn
            :disabled="!valid"
            @click="inserir"
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
import Tribos from '../../../domains/services/Tribos'
import { http } from '../../../domains/api/config'

export default {
  data: () => ({
    valid: true,
    nome: '',
    nomeRegras: [
      v => !!v || 'Nome da Squad é um campo obrigatório!',
      v => (v && v.length <= 50) || 'O nome deve ser menos que 50 caracteres'
    ],
    select: null,
    tribos: []
  }),

  methods: {
    inserir () {
      if (this.$refs.form.validate()) {
        http.post('/Squads/Inserir', {
          nome: this.nome,
          select: this.select
        })
      }
    },
    clear () {
      this.$refs.form.reset()
    }
  },

  mounted () {
    Tribos.obterTribo().then(respostaTribo => {
      console.log(respostaTribo.data)
      this.tribos = respostaTribo.data
    })
  }
}
</script>

<style>
.margemSeguranca {
  padding: 10px;
}
</style>
