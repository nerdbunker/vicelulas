<template>
  <v-container fluid grid-list-xs text-xs-center>
    <v-layout row wrap justify-center align-content-center>
      <v-flex xs10>
        <embed src="../../../static/pdf/viceri.pdf" width="100%" height="600" type='application/pdf'>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Viceri'
}
</script>
