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
import Squads from '@/app/organismo/Squads'
import Tribo from '@/app/organismo/Tribo'
import Tribos from '@/app/organismo/Tribos'
// App - Autenticacao
import Login from '@/app/acesso/Login'
import Adicionar from '@/app/acesso/gerencia/Adicionar'
import Gerenciar from '@/app/acesso/gerencia/Gerenciar'

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
    { path: '/tribos', name: 'Tribos', component: Tribos },
    { path: '/tribos/:name', name: 'Tribo', component: Tribo },
    { path: '/tribos/squads/:id', name: 'Squad', component: Squad },
    { path: '/squads', name: 'Squads', component: Squads },
    // App - Autenticacao
    { path: '/login', name: 'Login', component: Login },
    { path: '/adicionar', name: 'Adicionar', component: Adicionar },
    { path: '/gerenciar', name: 'Gerenciar', component: Gerenciar }
  ]
})
