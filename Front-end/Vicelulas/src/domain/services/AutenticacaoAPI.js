// Conexão de API para Entrar e Cadastrar

import { http } from '../api/config'

export default {
  entrar: (login) => {
    return http.post('Entrar', login)
  }
}
