// Global
import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/app/Home'
// App - Viceri
import Viceri from '@/app/viceri/Viceri'
import Duvidas from '@/app/viceri/Duvidas'
import Suporte from '@/app/viceri/Suporte'
import Valores from '@/app/viceri/Valores'
// App - Organismo
import Squad from '@/app/organismo/Squad'
import Tribo from '@/app/organismo/Tribo'
// App - Acesso
import Login from '@/app/acesso/Login'
import Adicionar from '@/app/acesso/gerencia/Adicionar'
import Gerenciar from '@/app/acesso/gerencia/Gerenciar'
import Historico from '@/app/acesso/gerencia/Historico'
import GerenciarPessoa from '@/app/acesso/crud/GerenciarPessoa'
import GerenciarTribo from '@/app/acesso/crud/GerenciarTribo'
import GerenciarSquad from '@/app/acesso/crud/GerenciarSquad'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    { path: '/', name: 'Home', component: Home },
    // App - Viceri
    { path: '/viceri', name: 'Viceri', component: Viceri },
    { path: '/duvidas', name: 'Dúvidas', component: Duvidas },
    { path: '/suporte', name: 'Suporte', component: Suporte },
    { path: '/valores', name: 'Valores', component: Valores },
    // App - Organismo
    { path: '/tribos/:name', name: 'Tribo', component: Tribo },
    { path: '/tribos/squads/:id', name: 'Squad', component: Squad },
    // App - Autenticacao
    { path: '/login', name: 'Login', component: Login },
    { path: '/adicionar', name: 'Adicionar', component: Adicionar },
    // App - Acesso - Gerencia (com rotas aninhadas)
    { path: '/gerenciar',
      name: 'Gerenciar',
      component: Gerenciar,
      children: [
        { path: '/historico', component: Historico },
        { path: '/gerenciarpessoa', component: GerenciarPessoa },
        { path: '/gerenciartribo', component: GerenciarTribo },
        { path: '/gerenciarsquad', component: GerenciarSquad }
      ]
    }
  ]
})
