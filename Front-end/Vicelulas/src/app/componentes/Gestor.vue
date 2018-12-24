<template>
  <v-flex md12 xs12>
    <v-chip
      v-for="(gestor, i) in gestores"
      :key="i"
      color="black"
      :text-color="gestor.cor"
    >
      <v-avatar>
        <v-icon>assistant</v-icon>
      </v-avatar>
      {{ gestor.nome }}
    </v-chip>
    <v-spacer></v-spacer>
  </v-flex>
</template>

<script>
export default {
  name: 'Gestor',
  data () {
    return {
      gestores: [
        { nome: 'Anderson', cor: 'blue' },
        { nome: 'Fantatho', cor: 'green' },
        { nome: 'Rafaela', cor: 'purple' }
      ]
    }
  }
}
</script>
