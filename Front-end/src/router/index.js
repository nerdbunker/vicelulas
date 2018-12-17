import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Login from '@/components/domain/Login'
import Viceri from '@/components/viceri/Viceri'
import Duvidas from '@/components/viceri/Duvidas'
import Suporte from '@/components/viceri/Suporte'
import Valores from '@/components/viceri/Valores'
import Adicionar from '@/components/domain/Adicionar'
import Squads from '@/components/organismo/Squads'
import Squad from '@/components/organismo/Squad'
import Tribos from '@/components/organismo/Tribos'
import Tribo from '@/components/organismo/Tribo'
import Gerenciar from '@/components/domain/Gerenciar'
// import EasterEgg from '@/components/viceri/EasterEgg'
import Teste from '@/components/viceri/Teste'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    { path: '/', name: 'Home', component: Home },
    { path: '/login', name: 'Login', component: Login },
    { path: '/viceri', name: 'Viceri', component: Viceri },
    { path: '/tribos', name: 'Tribos', component: Tribos },
    { path: '/tribos/:name', name: 'Tribo', component: Tribo },
    { path: '/tribos/squads/:id', name: 'Squad', component: Squad },
    { path: '/squads', name: 'Squads', component: Squads },
    { path: '/duvidas', name: 'Dúvidas', component: Duvidas },
    { path: '/suporte', name: 'Suporte', component: Suporte },
    { path: '/valores', name: 'Valores', component: Valores },
    { path: '/adicionar', name: 'Adicionar', component: Adicionar },
    { path: '/gerenciar', name: 'Gerenciar', component: Gerenciar },
    // { path: '/easteregg', name: 'Easter Egg', component: EasterEgg }
    { path: '/teste', name: 'Teste SVG', component: Teste }
  ]
})
