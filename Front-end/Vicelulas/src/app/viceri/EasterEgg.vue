<template>
  <v-container>
    <v-layout row justify-center align-content-center>
      <v-flex xs6>
        <v-card class="espacoBorda">
          <v-text-field
            name="lambda"
            label="Insira a chave correta para desbloquear"
            single-line
          ></v-text-field>
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="teal">Tentar</v-btn>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'EasterEgg'
}
function alerta () {
  let keyLambda

  if (keyLambda === 'lambda') {
    alert('Parabens você descobriu a chave!!')
  }
}

alerta()
</script>

<style>
.espacoBorda {
  padding-left: 5px;
  padding-right: 5px;
}
</style>
