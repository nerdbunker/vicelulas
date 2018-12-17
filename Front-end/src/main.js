import Vue from 'vue'
import App from './App'
import router from './router'
import {
  Vuetify,
  VApp,
  VNavigationDrawer,
  VFooter,
  VList,
  VBtn,
  VIcon,
  VImg,
  VGrid,
  VCard,
  VForm,
  VToolbar,
  VTextField,
  VCarousel,
  VCombobox,
  VExpansionPanel,
  VTabs,
  transitions
} from 'vuetify'
import '../node_modules/vuetify/src/stylus/app.styl'

Vue.use(Vuetify, {
  components: {
    VApp,
    VNavigationDrawer,
    VFooter,
    VList,
    VBtn,
    VIcon,
    VImg,
    VGrid,
    VCard,
    VForm,
    VToolbar,
    VTextField,
    VCarousel,
    VCombobox,
    VExpansionPanel,
    VTabs,
    transitions
  },
  theme: {
    primary: '#000000',
    secondary: '#ffffff',
    accent: '#9236ff',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#FFC107'
  }
})

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
