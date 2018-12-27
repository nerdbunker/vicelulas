import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    user: {
      name: 'Fabio',
      email: 'fabio@gmail.com',
      level: 'admin-gerente-executivo'
    },
    token: 'nksdkoa;jsdo;jasi;odjsd'
  },
  mutations: {
    'CHANGE_USER' (state, payload) {
      state.user = payload
    }
  },
  actions: {

  }
})
