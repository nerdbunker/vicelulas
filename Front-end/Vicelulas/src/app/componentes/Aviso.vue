<template>
  <div>
    <v-alert
      v-model="ativo"
      type="error"
    >
      {{ mensagem }}
    </v-alert>
  </div>
</template>

<script>
export default {
  props: ['ativo', 'mensagem']
}
</script>
