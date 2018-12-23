<template>
  <v-slide-y-transition>
    <v-container fluid>
      <v-layout align-center justify-center>
        <v-flex md7 xs12 pt-5>
          <v-card class="elevation-12">
            <v-card-text>
              <v-form>
                <v-text-field
                prepend-icon="person"
                name="email"
                label="E-mail"
                type="text"
                autofocus="true"
                ></v-text-field>
                <v-text-field
                id="senha"
                prepend-icon="lock"
                name="senha"
                label="Senha"
                type="password"
                ></v-text-field>
              </v-form>
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn to="/gerenciartribo" color="teal">Login</v-btn>
            </v-card-actions>
          </v-card>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
export default {
  props: {
    source: String
  }
}
</script>
