// Global
import Vue from 'vue'
import Router from 'vue-router'
// App - Viceri
import Home from '@/app/Home'
import Viceri from '@/app/viceri/Viceri'
import Duvidas from '@/app/viceri/Duvidas'
import Suporte from '@/app/viceri/Suporte'
import Valores from '@/app/viceri/Valores'
import Pessoas from '@/app/viceri/Pessoas'
import Documentos from '@/app/viceri/Documentos'
// App - Organismo
import Organismo from '@/app/organismo/Organismo'
import Squads from '@/app/organismo/Squads'
import Tribos from '@/app/organismo/Tribos'
// App - Acesso
import Entrar from '@/app/acesso/Entrar'
import Adicionar from '@/app/acesso/admin/Adicionar'
import Gerenciar from '@/app/acesso/admin/Gerenciar'
import Historico from '@/app/acesso/crud/Historico'
import Pessoa from '@/app/acesso/crud/Pessoa'
import Tribo from '@/app/acesso/crud/Tribo'
import Squad from '@/app/acesso/crud/Squad'

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
    { path: '/pessoas', name: 'Pessoas', component: Pessoas },
    { path: '/documentos', name: 'Documentos', component: Documentos },
    // App - Organismo
    { path: '/organismo', name: 'Organismo', component: Organismo },
    { path: '/tribos/:name', name: 'Tribos', component: Tribos },
    { path: '/tribos/squads/:id', name: 'Squads', component: Squads },
    // App - Autenticacao
    { path: '/entrar', name: 'Login', component: Entrar },
    { path: '/adicionar', name: 'Adicionar', component: Adicionar },
    // App - Acesso - Gerencia (com rotas aninhadas)
    { path: '/gerenciar',
      name: 'Gerenciar',
      component: Gerenciar,
      children: [
        { path: '/historico', component: Historico },
        { path: '/pessoa', component: Pessoa },
        { path: '/tribo', component: Tribo },
        { path: '/squad', component: Squad }
      ]
    }
  ]
})
