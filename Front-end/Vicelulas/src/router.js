// Global
import Vue from 'vue'
import Router from 'vue-router'
// App - Viceri
import Home from '@/app/Home'
import Viceri from '@/app/viceri/Viceri'
import Duvidas from '@/app/viceri/Duvidas'
import Suporte from '@/app/viceri/Suporte'
import Valores from '@/app/viceri/Valores'
import Documentos from '@/app/viceri/Documentos'
// App - Organismo
import Organismo from '@/app/organismo/Organismo'
import Tribos from '@/app/organismo/Tribos'
// App - Acesso
import Entrar from '@/app/acesso/Entrar'
// App - Acesso Admin
import Adicionar from '@/app/acesso/admin/Adicionar'
import Gerenciar from '@/app/acesso/admin/Gerenciar'
// App - Acesso CRUD
import Historico from '@/app/acesso/crud/Historico'
import Pessoa from '@/app/acesso/crud/Pessoa'
import Tribo from '@/app/acesso/crud/Tribo'
import Squad from '@/app/acesso/crud/Squad'
// App - Acesso Componentes
import InserirPessoa from '@/app/acesso/componentes/InserirPessoa'
import InserirTribo from '@/app/acesso/componentes/InserirTribo'
import InserirSquad from '@/app/acesso/componentes/InserirSquad'
import EditarPessoa from '@/app/acesso/componentes/EditarPessoa'
import EditarTribo from '@/app/acesso/componentes/EditarTribo'
import EditarSquad from '@/app/acesso/componentes/EditarSquad'
import Feedback from '@/app/acesso/componentes/Feedback'

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
    { path: '/documentos', name: 'Documentos', component: Documentos },
    // App - Organismo
    { path: '/organismo', name: 'Organismo', component: Organismo },
    { path: '/tribos/:id', name: 'Tribos', component: Tribos },
    // App - Autenticacao
    { path: '/entrar', name: 'Login', component: Entrar },
    { path: '/adicionar', name: 'Adicionar', component: Adicionar },
    // App - Acesso - Gerencia (com rotas aninhadas)
    { path: '/gerenciar',
      name: 'Gerenciar',
      component: Gerenciar,
      children: [
        { path: '/historico', component: Historico },
        { path: '/pessoa',
          component: Pessoa,
          children: [
            { path: '/inserirpessoa', component: InserirPessoa },
            { path: '/editarpessoa', component: EditarPessoa },
            { path: '/feedback', component: Feedback }
          ]
        },
        { path: '/tribo',
          component: Tribo,
          children: [
            { path: '/inserirtribo', component: InserirTribo },
            { path: '/editartribo', component: EditarTribo }
          ]
        },
        { path: '/squad',
          component: Squad,
          children: [
            { path: '/inserirsquad', component: InserirSquad },
            { path: '/editarsquad', component: EditarSquad }
          ]
        }
      ]
    }
  ]
})
