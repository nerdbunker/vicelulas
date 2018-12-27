// Conexão de API para Cadastro

import { http } from '../api/config'

export default {
  cadastrar: (cadastro) => {
    return http.post('Cadastrar')
  }
}
