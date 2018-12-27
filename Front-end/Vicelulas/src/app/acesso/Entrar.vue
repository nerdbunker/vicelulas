<template>
  <v-container fluid>
    <v-layout align-center justify-center>
      <v-flex md5 xs12 pt-5>
        <v-card dark>
          <v-card-text>
            <v-form>
              <v-text-field
              prepend-icon="person"
              name="email"
              label="E-mail"
              type="text"
              :autofocus="true"
              color="lime"
              ></v-text-field>
              <!--  -->
              <v-text-field
              id="senha"
              prepend-icon="lock"
              name="senha"
              label="Senha"
              type="password"
              color="lime"
              ></v-text-field>
            </v-form>
          </v-card-text>
          <!--  -->
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn pa-2 to="/tribo" color="lime" flat>Entrar</v-btn>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: 'Entrar',
  data () {
    return {
      true: true
    }
  }
}
</script>
