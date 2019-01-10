import Vue from 'vue'
// Plugins
import './plugins/axios'
import './plugins/vuetify'
// Motor da App
import App from './App.vue'
import router from './router'
import store from './store'
import './registerServiceWorker'
// Fontes como Dependencia
import 'material-design-icons-iconfont/dist/material-design-icons.css'
import '@mdi/font/css/materialdesignicons.css'
Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
