<template>
  <v-container grid-list-xs>
    <v-layout row wrap>
      <v-flex xs12>
        {{ msg }}
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Feedback',
  data () {
    return {
      msg: 'Minha página de feedback.'
    }
  }
}
</script>
