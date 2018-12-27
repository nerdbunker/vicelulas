import Vue from 'vue'
import Vuetify from 'vuetify/lib'
import 'vuetify/src/stylus/app.styl'
import pt from 'vuetify/es5/locale/pt'

Vue.use(Vuetify, {
  theme: {
    primary: '#000000',
    secondary: '#ffffff',
    accent: '#FC0001',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#FFC107',
    viceri: '#FC0001',
    cinza: '#323234'
  },
  iconfont: 'md',
  lang: {
    locales: { pt },
    current: 'pt'
  }
})
