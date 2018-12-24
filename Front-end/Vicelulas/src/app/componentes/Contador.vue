<template>
  <v-flex d-flex md8 xs12>
    <v-flex md4 xs12 pa-3>
      <v-chip color="teal" text-color="black">
        <v-avatar>
          <v-icon>bubble_chart</v-icon>
        </v-avatar>
        Tribos: {{ contador.tribos }}
      </v-chip>
    </v-flex>
    <v-spacer></v-spacer>
    <v-flex md4 xs12 pa-3>
      <v-chip color="teal" text-color="black">
        <v-avatar>
          <v-icon>grain</v-icon>
        </v-avatar>
        Squads: {{ contador.squads }}
      </v-chip>
    </v-flex>
    <v-spacer></v-spacer>
    <v-flex md4 xs12 pa-3>
      <v-chip color="teal" text-color="black">
        <v-avatar>
          <v-icon>person</v-icon>
        </v-avatar>
        Pessoas: {{ contador.pessoas }}
      </v-chip>
    </v-flex>
  </v-flex>
</template>

<script>
export default {
  name: 'Contador',
  data () {
    return {
      contador: {
        tribos: 7,
        squads: 15,
        pessoas: 97
      }
    }
  }
}
</script>
