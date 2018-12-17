<template>
  <v-slide-y-transition>
    <v-container fluid fill-height>
      <v-layout align-center justify-center>
        <v-flex xs6>
          <v-card class="elevation-12">
            <v-card-text>
              <v-form>
                <v-text-field
                prepend-icon="person"
                name="nome"
                label="Nome Completo"
                type="text"
                autofocus="true"
                clear-icon="limpar"
                ></v-text-field>

                <v-text-field
                prepend-icon="mail"
                name="email"
                label="E-mail"
                type="text"
                required
                ></v-text-field>

                <v-combobox
                  prepend-icon="work"
                  v-model="select"
                  :items="cargos"
                  label="Papel"
                  required
                ></v-combobox>

                <v-combobox
                  prepend-icon="home"
                  v-model="select"
                  :items="unidades"
                  label="Unidade"
                  required
                ></v-combobox>

                <v-text-field
                id="senha"
                prepend-icon="lock"
                name="senha"
                label="Senha"
                type="password"
                required
                ></v-text-field>
              </v-form>
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="teal">Adicionar</v-btn>
            </v-card-actions>
          </v-card>
        </v-flex>
      </v-layout>
    </v-container>
  </v-slide-y-transition>
</template>

<script>
  export default {
    name: 'Adicionar',
    data () {
      return {
        cargos: [
          'Gerente',
          'Coordenador',
          'Analista de Negócios',
          'Analista de Sistemas',
          'Arquiteto Back-end',
          'Arquiteto Front-end',
          'Cientista de Dados',
          'Desenvolvedor Sênior',
          'Desenvolvedor Pleno',
          'Desenvolvedor Junior',
          'Desenvolvedor Treinee',
          'Desenvolvedor Estagiário'
        ],
        unidades: [
          'Viceri Specialist - General Osório',
          'Viceri Specialist - Edificio Vila Jobim',
          'Viceri Ventures - Nove de Julho',
          'Viceri Solutions - São Paulo'
        ]
      }
    }
  }
</script>

