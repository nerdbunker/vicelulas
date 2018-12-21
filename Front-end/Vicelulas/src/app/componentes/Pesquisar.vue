<template>
  <div id="pesquisar">
    <v-text-field
      class="search"
      color="red"
      v-model="search"
      append-icon="search"
      label="Pesquisar"
      single-line
      hide-details
    ></v-text-field>
  </div>
</template>

<script>
export default {
  name: 'Pesquisar'
}
</script>

<style>
.search {
  padding-right: 5px;
  padding-left: 5px;
  padding-bottom: 10px;
}
</style>
