// Conexão de API para Entrar e Cadastrar

import { http } from '../api/config'

export default {
  entrar: () => {
    return http.post('Entrar', {
      id: this.id,
      email: this.email,
      senha: this.senha
    })
  }
}
