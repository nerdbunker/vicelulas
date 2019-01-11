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
import Cadastrar from '@/app/acesso/Cadastrar'
// App - Acesso Admin
import Gerenciar from '@/app/acesso/admin/Gerenciar'
// App - Acesso CRUD
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
    { path: '/documentos', name: 'Documentos', component: Documentos },
    // App - Organismo
    { path: '/organismo', name: 'Organismo', component: Organismo },
    { path: '/tribos/:id', name: 'Tribos', component: Tribos },
    { path: '/tribos/:id', name: 'Tribos', component: Tribos },
    // App - Autenticacao
    { path: '/entrar', name: 'Entrar', component: Entrar },
    { path: '/cadastrar', name: 'Cadastrar', component: Cadastrar },
    // App - Acesso - Gerencia (com rotas aninhadas)
    {
      path: '/gerenciar',
      name: 'Gerenciar',
      component: Gerenciar,
      children: [
        { path: '/historico', component: Historico, name: 'HistoricoCRUD' },
        { path: '/pessoa', component: Pessoa, name: 'PessoaCRUD' },
        { path: '/tribo', component: Tribo, name: 'TriboCRUD' },
        { path: '/squad', component: Squad, name: 'SquadCRUD' }
      ]
    }
  ]
})
