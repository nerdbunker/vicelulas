<template>
  <v-carousel>
    <v-carousel-item
      v-for="(foto,i) in fotos"
      :key="i"
      :src="foto.src"
      reverse-transition="fade"
      transition="fade"
    ></v-carousel-item>
  </v-carousel>
</template>

<script>
export default {
  name: 'Viceri',
  data () {
    return {
      // Imagens para o for do Carousel
      fotos: [
        { src: require('../../../static/mindset/fotos/1.jpeg') },
        { src: require('../../../static/mindset/fotos/2.jpeg') },
        { src: require('../../../static/mindset/fotos/3.jpeg') },
        { src: require('../../../static/mindset/fotos/4.jpeg') }
      ]
    }
  }
}
</script>
