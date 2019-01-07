<template>
  <v-container fluid>
    <v-layout align-center justify-center>
      <v-flex md5 xs12 pt-5>
        <v-card dark>
          <v-card-text>
            <v-form>
              <v-text-field
              v-model="username"
              prepend-icon="person"
              name="username"
              label="Usuário"
              type="text"
              autofocus="true"
              color="blue"
              ></v-text-field>
              <!--  -->
              <v-text-field
              id="senha"
              prepend-icon="lock"
              name="senha"
              label="Senha"
              type="password"
              color="blue"
              ></v-text-field>
            </v-form>
          </v-card-text>
          <!--  -->
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn pa-2 to="/tribo" color="blue" flat>Entrar</v-btn>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>
