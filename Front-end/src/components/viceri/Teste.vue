<template>
  <div id="teste">
    <div class="animate">
      <img src="../../../static/imagens/celula.svg" alt="">
    </div>
  </div>
</template>

<script>
export default {
  name: 'Teste'
}
</script>

<style>
.animate {
  animation-name: girando;
  animation-duration: 50s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
}

@keyframes girando {
  from {
  transform: rotate(0deg);
}
  to {
    transform: rotate(360deg);
  }
}
</style>
